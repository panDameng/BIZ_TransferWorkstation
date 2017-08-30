using System;
using Mes.ControlsEx;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BIZ_TransferWorkstation
{
    public partial class MainForm : Mes.ControlsEx.ExtendForm.BaseForm
    {
        string querySql = string.Empty;

        public MainForm()
        {
            InitializeComponent();

            //EventHandler deleteDoc = new EventHandler(onDelete);
            //this.navigatorEx1.AddButton("删除", deleteDoc);
            //this.navigatorEx1.AddButton("数量刷新", refreshQty);
            //this.navigatorEx1.AddButton("同步搬运单", DoSync);
            //this.navigatorEx1.AddButton("撤销行", Cancel);
            //this.navigatorEx1.AddButton("延交申请", DelayOn);
            
            this.navigatorEx1.DataGridView = this.dataGridViewEx1;
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
        }

        void nafigatorEx1_OnQuery(object sender, Mes.Core.ApplicationObject.SystemNavigatorClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = "select * from hfwk_users";
        }
        // 刷新数量
        //private void refreshQty(object sender, System.EventArgs e)
        //{
        //    if (this.dataGridViewEx1.RowCount > 0 && this.dataGridViewEx1.SelectedRows.Count > 0)
        //    {
        //        List<string> refreshSqlList = new List<string>();
        //        for (int i = 0; i < this.dataGridViewEx1.SelectedRows.Count; i++)
        //        {
        //            string sql = "{? = call yczm_transfer_doc_pkg.refresh_qty_for_ui(" +
        //                (string)this.dataGridViewEx1.SelectedRows[i].Cells[this.KID.Name].Value + ")}";
        //            refreshSqlList.Add(sql);
        //        }
        //        this.navigatorEx1.UpdateSqlList = refreshSqlList;
        //        this.navigatorEx1.tsbSave_Click(null, null);
        //        this.navigatorEx1.QuerySql = querySql;
        //    }
        //}

        //private void onDelete(object sender, EventArgs e)
        //{
        //    if (this.dataGridViewEx1.CurrentRow != null && this.dataGridViewEx1.RowCount > 0)
        //    {
        //        DialogResult result = MessageBox.Show("是否删除物料搬运单行？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (result.Equals(DialogResult.Yes))
        //        {
        //            string kid = (string)this.dataGridViewEx1.CurrentRow.Cells[this.KID.Name].Value;
        //            string sql = "{?=call yczm_transfer_doc_pkg.delete_transfer_doc_for_ui('" + kid + "')}";
        //            string msg = (string)Mes.Core.Service.DatabaseAccessService.execute(sql, Mes.Core.Service.ReturnType.STRING);
        //            if (!msg.StartsWith("0@"))
        //            {
        //                MessageBox.Show(msg);
        //                return;
        //            }
        //            else
        //            {
        //                this.dataGridViewEx1.Rows.Remove(this.dataGridViewEx1.CurrentRow);
        //                Mes.Core.Service.MessageService.ShowMessage("删除成功");
        //            }
        //        }
        //    }
        //}

        private void MainForm_OnQuery(object sender, Mes.Core.ApplicationObject.SystemNavigatorClickedEventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.ShowDialog();

            querySql = queryForm.QuerySql;
            this.navigatorEx1.QuerySql = querySql;
        }

        //// 同步数据
        //private void DoSync(object sender, System.EventArgs e)
        //{
        //    string sql = "{? = yczm_import_move_order_pkg.main }";
        //    string msg = (string)Mes.Core.Service.DatabaseAccessService.execute(sql, Mes.Core.Service.ReturnType.STRING);
        //    Mes.Core.Service.MessageService.ShowMessage("同步成功");
        //}

        //private void Cancel(object sender, System.EventArgs e)
        //{
        //    if (this.dataGridViewEx1.CurrentRow != null && this.dataGridViewEx1.RowCount > 0)
        //    {
        //        DialogResult result = MessageBox.Show("确认要撤销物料搬运单行？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (result.Equals(DialogResult.Yes))
        //        {
        //            string kid = (string)this.dataGridViewEx1.CurrentRow.Cells[this.KID.Name].Value;
        //            string sql = "{?=call yczm_transfer_doc_pkg.cancel_transfer_doc_for_ui('" + kid + "')}";
        //            string msg = (string)Mes.Core.Service.DatabaseAccessService.execute(sql, Mes.Core.Service.ReturnType.STRING);
        //            if (!msg.StartsWith("0@"))
        //            {
        //                MessageBox.Show(msg);
        //                return;
        //            }
        //            else
        //            {
        //                this.dataGridViewEx1.Rows.Remove(this.dataGridViewEx1.CurrentRow);
        //                Mes.Core.Service.MessageService.ShowMessage("撤销成功");
        //            }
        //        }
        //    }
        //}
        //private void DelayOn(object sender, System.EventArgs e)
        //{
        //    if (this.dataGridViewEx1.CurrentRow != null && this.dataGridViewEx1.RowCount > 0)
        //    {
        //        DialogResult result = MessageBox.Show("确认要全部延交物料搬运单行?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (result.Equals(DialogResult.Yes))
        //        {
        //            string kid = (string)this.dataGridViewEx1.CurrentRow.Cells[this.KID.Name].Value;
        //            string sql = "{?=call yczm_transfer_doc_pkg.delay_transfer_line_for_ui(" + kid + ")}";
        //            string msg = (string)Mes.Core.Service.DatabaseAccessService.execute(sql, Mes.Core.Service.ReturnType.STRING);
        //            if (!msg.StartsWith("0@"))
        //            {
        //                MessageBox.Show(msg);
        //                return;
        //            }
        //            else
        //            {
        //                this.dataGridViewEx1.Rows.Remove(this.dataGridViewEx1.CurrentRow);
        //                Mes.Core.Service.MessageService.ShowMessage("延交成功");
        //            }
        //        }
        //    }
        //}

        private void navigatorEx1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewEx1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
