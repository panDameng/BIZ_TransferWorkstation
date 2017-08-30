using Mes.ControlsEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ_TransferWorkstation.Sql
{
    class QuerySql
    {
        // 子物料搬运单号
        public static string getSubDocSql()
        {
            string sql = @"SELECT ytd.sub_document_number A,
                                   ytd.sub_document_number B,
                                   ytd.document_number
                              FROM yczm_transfer_doc ytd
                             WHERE 1 = 1
                               AND ytd.sub_document_number" + Mes.Core.Utility.StrUtil.SQL_PLACEHOLDER;

            /*
            if ( Mes.Core.Config.ApplicationConfig.getProperty("DEFAULT_PLANT_ID").Equals("90"))
            {
                sql += @" AND EXISTS ( SELECT 1
                                                        FROM yczm_user_store_group usg
                                                       WHERE usg.user_id = " + Mes.Core.Config.ApplicationConfig.getCurrentUser().UserId + @"
                                                         AND (ytd.store_group = usg.store_group OR usg.store_group = 'G00')
                                                         AND ytd.plant_id = 90 )";

            }
            else if (!Mes.Core.Config.ApplicationConfig.getProperty("DEFAULT_PLANT_ID").Equals("88"))
            {
                sql += " AND " + Mes.Core.Config.ApplicationConfig.getProperty("DEFAULT_PLANT_ID") + @" = ytd.plant_id 
                                       AND ytd.plant_id <> 90";
            }*/

            sql += @" AND yczm_transfer_pda_pck.valid_private( p_plant_id    => ytd.plant_id,
                                                               p_store_group => ytd.store_group) = 'Y'";


            sql += @" GROUP BY ytd.sub_document_number,
                                   ytd.document_number";

            return sql;
        }

        // 物料搬运单号
        public static string getDocSql()
        {
            string sql = @"SELECT ytd.document_number A,
                                  ytd.document_number B
                              FROM yczm_transfer_doc ytd
                             WHERE 1 = 1
                               AND ytd.document_number" + Mes.Core.Utility.StrUtil.SQL_PLACEHOLDER;

            /*
            if (Mes.Core.Config.ApplicationConfig.getProperty("DEFAULT_PLANT_ID").Equals("90"))
            {
                sql += @" AND EXISTS ( SELECT 1
                                                        FROM yczm_user_store_group usg
                                                       WHERE usg.user_id = " + Mes.Core.Config.ApplicationConfig.getCurrentUser().UserId + @"
                                                         AND (ytd.store_group = usg.store_group OR usg.store_group = 'G00')
                                                         AND ytd.plant_id = 90 )";

            }
            else if (!Mes.Core.Config.ApplicationConfig.getProperty("DEFAULT_PLANT_ID").Equals("88"))
            {
                sql += " AND " + Mes.Core.Config.ApplicationConfig.getProperty("DEFAULT_PLANT_ID") + @" = ytd.plant_id 
                                       AND ytd.plant_id <> 90";
            }
            */
            sql += @" AND yczm_transfer_pda_pck.valid_private( p_plant_id    => ytd.plant_id,
                                                               p_store_group => ytd.store_group) = 'Y'";

            sql += @" GROUP BY ytd.document_number";


            return sql;
        }

        // 图号
        public static string getPictureNumSql()
        {
            string sql = @"SELECT hi.old_item_code A,
                                  hi.old_item_code B
                              FROM hcm_item hi
                             WHERE 1 = 1
                               AND hi.old_item_code" + Mes.Core.Utility.StrUtil.SQL_PLACEHOLDER;
            return sql;
        }

        // 物料编码
        public static string getItemSql()
        {
            string sql = @"SELECT hi.item_id,
                                   hi.item_code,
                                   hi.descriptions,
                                   hp.descriptions plant_name
                              FROM hcm_item hi, hcm_plant hp
                             WHERE 1 = 1
                               AND hi.plant_id = hp.plant_id
                               AND (hi.item_code" + Mes.Core.Utility.StrUtil.SQL_PLACEHOLDER +
                                   " OR hi.descriptions" + Mes.Core.Utility.StrUtil.SQL_PLACEHOLDER + ")";
            return sql;
        }

        // 客户
        public static string getCustomSql()
        {
            string sql = @"SELECT hc.customer_id,
                                   hc.customer_name,
                                   hc.customer_code
                              FROM hcm_customers hc
                             WHERE 1 = 1
                               AND (hc.customer_code" + Mes.Core.Utility.StrUtil.SQL_PLACEHOLDER +
                                   " OR hc.customer_name" + Mes.Core.Utility.StrUtil.SQL_PLACEHOLDER + ")";
            return sql;
        }

        public static string GetQuerySql(string subDocNumFrom, string subDocNumTo, string docNum, string customID,
            string picutreNum, string itemId, string docType)
        {
            /*
            string sql = @" SELECT ytd.kid,
                                   ytd.sub_document_number,
                                   ytd.document_number,
                                   ytd.line_num,
                                   hlt.meaning AS doc_type,
                                   ytd.sales_order_num,
                                   ytd.sales_order_line_num,
                                   hp.descriptions,
                                   hi.item_code,
                                   hi.descriptions,
                                   hi.old_item_code,
                                   ytd.request_quantity,
                                   ytd.quantity,
                                   SUM(ybe.encasement_qty) AS scan_qty,
                                   ytd.uom,
                                   ytd.price,
                                   hc.customer_name,
                                   nvl2(ytd.shipping_instructions,ytd.shipping_instructions,hcs.cust_site_code) AS cust_site,
                                   ytd.store_group,
                                   ytd.subinventory_code,
                                   ytd.locator_code,
                                   ytd.target_suninv_code,
                                   ytd.target_locator_code,
                                   decode(ytd.process_erp_status,
                                          'E',
                                          '错误',
                                          'S',
                                          '成功',
                                          NULL),
                                   ytd.process_message
                              FROM yczm_transfer_doc   ytd,
                                   hfwk_lookup_types_v hlt,
                                   hcm_item            hi,
                                   yczm_barcode_events ybe,
                                   hcm_customers       hc,
                                   hcm_customer_site   hcs,
                                   hcm_plant           hp
                             WHERE 1 = 1
                               AND ytd.plant_id = hp.plant_id
                               AND ytd.document_type = hlt.lookup_code
                               AND hlt.lookup_type_code = 'YCZM_TXN_REQUEST_TYPE'
                               AND ytd.item_id = hi.item_id
                               AND ytd.plant_id = hi.plant_id
                               AND ytd.kid = ybe.source_line_id(+)
                               AND ybe.source_line_type(+) = 'MO'
                               AND ytd.customer_id = hc.customer_id(+)
                               AND ytd.customer_site_id = hcs.customer_site_id(+)
                               AND (" + Mes.Core.Config.ApplicationConfig.getProperty("DEFAULT_PLANT_ID") + " = 88 or ytd.plant_id = nvl(" + Mes.Core.Config.ApplicationConfig.getProperty("DEFAULT_PLANT_ID") + ", -1))";
            */

            string sql = @" SELECT ytd.kid,
                                   ytd.sub_document_number,
                                   ytd.document_number,
                                   ytd.line_num,
                                   hlt.meaning AS doc_type,
                                   ytd.sales_order_num,
                                   ytd.sales_order_line_num,
                                   hp.descriptions,
                                   hi.item_code,
                                   hi.descriptions,
                                   hi.old_item_code,
                                   ytd.request_quantity,
                                   ytd.quantity,
                                   yczm_barcode_pkg.get_connect_barcode_qty( p_doc_id => ytd.kid,
                                                                             p_doc_type => 'MO',
                                                                             p_barcode_status => 'SCANNED' ) scan_qty,
                                   ytd.uom,
                                   ytd.price,
                                   hc.customer_name,
                                   nvl2(ytd.shipping_instructions,ytd.shipping_instructions,hcs.cust_site_code) AS cust_site,
                                   ytd.store_group,
                                   ytd.subinventory_code,
                                   ytd.locator_code,
                                   ytd.target_suninv_code,
                                   ytd.target_locator_code,
                                   decode(ytd.process_erp_status,
                                          'E',
                                          '错误',
                                          'S',
                                          '成功',
                                          NULL),
                                   ytd.process_message
                              FROM yczm_transfer_doc   ytd,
                                   hfwk_lookup_types_v hlt,
                                   hcm_item            hi,
                                   hcm_customers       hc,
                                   hcm_customer_site   hcs,
                                   hcm_plant           hp
                             WHERE 1 = 1
                               AND ytd.plant_id = hp.plant_id
                               AND ytd.document_type = hlt.lookup_code
                               AND hlt.lookup_type_code = 'YCZM_TXN_REQUEST_TYPE'
                               AND ytd.item_id = hi.item_id
                               AND ytd.plant_id = hi.plant_id
                               AND ytd.customer_id = hc.customer_id(+)
                               AND ytd.customer_site_id = hcs.customer_site_id(+)
                               AND (" + Mes.Core.Config.ApplicationConfig.getProperty("DEFAULT_PLANT_ID") + " = 88 or ytd.plant_id = nvl(" + Mes.Core.Config.ApplicationConfig.getProperty("DEFAULT_PLANT_ID") + ", -1))";

            if (!string.IsNullOrEmpty(subDocNumFrom))
            {
                sql += "  AND ytd.sub_document_number >= '" + subDocNumFrom + "'";
            }
            if (!string.IsNullOrEmpty(subDocNumTo))
            {
                sql += "  AND ytd.sub_document_number <= '" + subDocNumTo + "'";
            }
            if (!string.IsNullOrEmpty(docNum))
            {
                sql += "  AND ytd.document_number = '" + docNum + "'";
            }
            if (!string.IsNullOrEmpty(customID))
            {
                sql += "  AND  ytd.customer_id = " + customID;
            }
            if (!string.IsNullOrEmpty(picutreNum))
            {
                sql += "  AND  hi.old_item_code = '" + picutreNum + "'";
            }
            if (!string.IsNullOrEmpty(itemId))
            {
                sql += "  AND  ytd.item_id = " + itemId;
            }
            if (!string.IsNullOrEmpty(docType))
            {
                sql += "  AND  ytd.document_type = '" + docType + "'";
            }

            /*
            if (Mes.Core.Config.ApplicationConfig.getProperty("DEFAULT_PLANT_ID").Equals("90"))
            {
                sql += @" AND EXISTS ( SELECT 1
                                                        FROM yczm_user_store_group usg
                                                       WHERE usg.user_id = " + Mes.Core.Config.ApplicationConfig.getCurrentUser().UserId + @"
                                                         AND (ytd.store_group = usg.store_group OR usg.store_group = 'G00')
                                                         AND ytd.plant_id = 90 )";

            }
            else if (!Mes.Core.Config.ApplicationConfig.getProperty("DEFAULT_PLANT_ID").Equals("88"))
            {
                sql += " AND " + Mes.Core.Config.ApplicationConfig.getProperty("DEFAULT_PLANT_ID") + @" = ytd.plant_id 
                                       AND ytd.plant_id <> 90";
            }*/
            sql += @" AND yczm_transfer_pda_pck.valid_private( p_plant_id    => ytd.plant_id,
                                                               p_store_group => ytd.store_group) = 'Y'";


            sql += @"  GROUP BY ytd.kid,
                                  ytd.sub_document_number,
                                  ytd.document_number,
                                  ytd.line_num,
                                  hlt.meaning,
                                  ytd.sales_order_num,
                                  ytd.sales_order_line_num,
                                  hp.descriptions,
                                  hi.item_code,
                                  hi.descriptions,
                                  hi.old_item_code,
                                  ytd.request_quantity,
                                  ytd.quantity,
                                  ytd.uom,
                                  ytd.price,
                                  hc.customer_name,
                                  ytd.shipping_instructions,
                                  hcs.cust_site_code,
                                  ytd.store_group,
                                  ytd.subinventory_code,
                                  ytd.locator_code,
                                  ytd.target_suninv_code,
                                  ytd.target_locator_code,
                                  ytd.process_erp_status,
                                  ytd.process_message
                         ORDER BY ytd.document_number";

            return sql;
        }

    }
    
}
