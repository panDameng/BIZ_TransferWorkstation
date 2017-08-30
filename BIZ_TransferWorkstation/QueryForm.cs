using Mes.ControlsEx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BIZ_TransferWorkstation
{
    public partial class QueryForm : Mes.ControlsEx.ExtendForm.QueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            //控件初始化
            // Lov
            initialize_Lov();
        }

        // Lov 初始化
        private void initialize_Lov()
        {
            // Lov of subDocument
            LovFormExParameter subDocLov = new LovFormExParameter();
            subDocLov.QuerySql = Sql.QuerySql.getSubDocSql();
            subDocLov.LovFormExTitle = Mes.Core.Utility.StrUtil.Translate("子物料搬运单查找");
            subDocLov.ColumnsName.Add("子物料搬运单号1");
            subDocLov.ColumnsName.Add("子物料搬运单号");
            subDocLov.ColumnsName.Add("物料搬运单号");
            subDocLov.ColumnVisableList.Add(false);
            subDocLov.ColumnVisableList.Add(true);
            subDocLov.ColumnVisableList.Add(true);
            subDocLov.IsUseInDataGridView = false;
            subDocLov.TargetTextBoxEx = this.subDocFromTxb;
            this.subDocFromLov.LovParameter = subDocLov;

            // Lov of subDocument
            LovFormExParameter subDocToLov = new LovFormExParameter();
            subDocToLov.QuerySql = Sql.QuerySql.getSubDocSql();
            subDocToLov.LovFormExTitle = Mes.Core.Utility.StrUtil.Translate("子物料搬运单查找");
            subDocToLov.ColumnsName.Add("子物料搬运单号1");
            subDocToLov.ColumnsName.Add("子物料搬运单号");
            subDocToLov.ColumnsName.Add("物料搬运单号");
            subDocToLov.ColumnVisableList.Add(false);
            subDocToLov.ColumnVisableList.Add(true);
            subDocToLov.ColumnVisableList.Add(true);
            subDocToLov.IsUseInDataGridView = false;
            subDocToLov.TargetTextBoxEx = this.subDocToTxb;
            this.subDocToLov.LovParameter = subDocToLov;

            // Lov of document
            LovFormExParameter docLov = new LovFormExParameter();
            docLov.QuerySql = Sql.QuerySql.getDocSql();
            docLov.LovFormExTitle = Mes.Core.Utility.StrUtil.Translate("物料搬运单查找");
            docLov.ColumnsName.Add("物料搬运单号1");
            docLov.ColumnsName.Add("物料搬运单号");
            docLov.ColumnVisableList.Add(false);
            docLov.ColumnVisableList.Add(true);
            docLov.IsUseInDataGridView = false;
            docLov.TargetTextBoxEx = this.docTxb;
            this.docLov.LovParameter = docLov;

            // Lov of custom.
            LovFormExParameter customLp = new LovFormExParameter();
            customLp.QuerySql = Sql.QuerySql.getCustomSql();
            customLp.LovFormExTitle = Mes.Core.Utility.StrUtil.Translate("客户查找");
            customLp.ColumnsName.Add("ID");
            customLp.ColumnsName.Add("客户名称");
            customLp.ColumnsName.Add("客户编码");
            customLp.ColumnVisableList.Add(false);
            customLp.ColumnVisableList.Add(true);
            customLp.ColumnVisableList.Add(true);
            customLp.IsUseInDataGridView = false;
            customLp.TargetTextBoxEx = this.customTxb;
            this.customLov.LovParameter = customLp;

            // Lov of picture number.
            LovFormExParameter pictureLp = new LovFormExParameter();
            pictureLp.QuerySql = Sql.QuerySql.getPictureNumSql();
            pictureLp.LovFormExTitle = Mes.Core.Utility.StrUtil.Translate("图号查找");
            pictureLp.ColumnsName.Add("图号1");
            pictureLp.ColumnsName.Add("图号");
            pictureLp.ColumnVisableList.Add(false);
            pictureLp.ColumnVisableList.Add(true);
            pictureLp.IsUseInDataGridView = false;
            pictureLp.TargetTextBoxEx = this.pictureNumTxb;
            this.pictureNumLov.LovParameter = pictureLp;

            // Lov of item.
            LovFormExParameter itemLp = new LovFormExParameter();
            itemLp.QuerySql = Sql.QuerySql.getItemSql();
            itemLp.LovFormExTitle = Mes.Core.Utility.StrUtil.Translate("物料查找");
            itemLp.ColumnsName.Add("ITEMID");
            itemLp.ColumnsName.Add("物料编号");
            itemLp.ColumnsName.Add("物料描述");
            itemLp.ColumnsName.Add("工厂");
            itemLp.ColumnVisableList.Add(false);
            itemLp.ColumnVisableList.Add(true);
            itemLp.ColumnVisableList.Add(true);
            itemLp.ColumnVisableList.Add(true);
            itemLp.IsUseInDataGridView = false;
            itemLp.TargetTextBoxEx = this.itemTxb;
            this.itemLov.LovParameter = itemLp;
            this.itemTxb.OnLovCompleted += itemTxb_OnLovCompleted;
        }

        void itemTxb_OnLovCompleted(Mes.Core.ApplicationObject.SystemTextBoxExRealValueChangedEventArgs e)
        {
            if (this.itemTxb.LovFormReturnValue.Count > 2)
            {
                this.itemDescTxb.Text = this.itemTxb.LovFormReturnValue[2];
            }
            if (string.IsNullOrEmpty(this.itemTxb.Text))
            {
                this.itemDescTxb.Text = "";
            }
        }

        private void QueryForm_OnCancelQuery(object sender, EventArgs e)
        {
            Mes.ControlsEx.ControlService.ClearSubControl(this);
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            this.QuerySql = Sql.QuerySql.GetQuerySql(this.subDocFromTxb.realValue, this.subDocToTxb.realValue, this.docTxb.Text,
                this.customTxb.realValue, this.pictureNumTxb.Text, this.itemTxb.realValue, (string)this.docTypeCbb.SelectedValue);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
