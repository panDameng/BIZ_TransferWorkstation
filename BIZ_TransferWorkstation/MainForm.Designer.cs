using Mes.ControlsEx;

namespace BIZ_TransferWorkstation
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Mes.ControlsEx.Class.ORM orm2 = new Mes.ControlsEx.Class.ORM();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.panelEx1 = new Mes.ControlsEx.PanelEx(this.components);
            this.statusStripBarEx1 = new Mes.ControlsEx.StatusStripBarEx();
            this.dataGridViewEx1 = new Mes.ControlsEx.DataGridViewEx(this.components);
            this.KID = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.subDocNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.docNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.rownum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.docType = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.salesOrderNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.salesOrderLineNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.plant_name = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.itemNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.itemDesc = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.pictureNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.requestQty = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.quantity = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.totalScanQty = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.uom = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.price = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.custom = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.customSite = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.storeGroup = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.subinv = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.locator = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.targetSuninv = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.targetLocator = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.process_erp_flag = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.process_message = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.navigatorEx1 = new Mes.ControlsEx.NavigatorEx();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.statusStripBarEx1);
            this.panelEx1.Controls.Add(this.dataGridViewEx1);
            this.panelEx1.Controls.Add(this.navigatorEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(2);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1018, 555);
            this.panelEx1.TabIndex = 0;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(3, 530);
            this.statusStripBarEx1.Margin = new System.Windows.Forms.Padding(2);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Size = new System.Drawing.Size(1015, 22);
            this.statusStripBarEx1.TabIndex = 2;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AddedRows = ((System.Collections.Generic.List<string>)(resources.GetObject("dataGridViewEx1.AddedRows")));
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToOrderColumns = true;
            this.dataGridViewEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEx1.AutoQuerySql = null;
            this.dataGridViewEx1.ChangedRows = ((System.Collections.Generic.List<string>)(resources.GetObject("dataGridViewEx1.ChangedRows")));
            this.dataGridViewEx1.CheckBoxCellIndex = -1;
            this.dataGridViewEx1.CheckBoxCheckedRow = null;
            this.dataGridViewEx1.ColumnHeadersHeight = 30;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KID,
            this.subDocNum,
            this.docNum,
            this.rownum,
            this.docType,
            this.salesOrderNum,
            this.salesOrderLineNum,
            this.plant_name,
            this.itemNum,
            this.itemDesc,
            this.pictureNum,
            this.requestQty,
            this.quantity,
            this.totalScanQty,
            this.uom,
            this.price,
            this.custom,
            this.customSite,
            this.storeGroup,
            this.subinv,
            this.locator,
            this.targetSuninv,
            this.targetLocator,
            this.process_erp_flag,
            this.process_message});
            orm2.ColumnCommPropertyList = "";
            orm2.DelSqlTemplate = "";
            orm2.InsertSqlTemplate = "";
            orm2.PrimaryTable = "";
            orm2.SelectSqlTemplate = "";
            orm2.UpdateSqlTemplate = "";
            this.dataGridViewEx1.DBORM = orm2;
            this.dataGridViewEx1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dataGridViewEx1.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dataGridViewEx1.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dataGridViewEx1.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dataGridViewEx1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewEx1.IsCheckBoxBecomeRadio = false;
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.IsUseORM = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewEx1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.NeedReceIveValue = false;
            this.dataGridViewEx1.OperationMode = "";
            this.dataGridViewEx1.PkCellIndex = 0;
            this.dataGridViewEx1.ReceiveValueColumnIndex = -1;
            this.dataGridViewEx1.RelationDataGridView = null;
            this.dataGridViewEx1.RelationDataGridViewColumnIndexList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.RelationDataGridViewColumnIndexList")));
            this.dataGridViewEx1.RelationDataGridViewQuerySql = "";
            this.dataGridViewEx1.RowTemplate.Height = 27;
            this.dataGridViewEx1.Size = new System.Drawing.Size(1012, 497);
            this.dataGridViewEx1.TabIndex = 1;
            this.dataGridViewEx1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEx1_CellContentClick);
            // 
            // KID
            // 
            this.KID.Alterable = true;
            this.KID.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KID.DefaultCellStyle = dataGridViewCellStyle26;
            this.KID.HeaderText = "KID";
            this.KID.IgnoreValueChanged = false;
            this.KID.IndexOrder = 0;
            this.KID.IsShowTimePick = false;
            this.KID.LovParameter = null;
            this.KID.MustBeInput = false;
            this.KID.MustBeInputErrorMsg = "";
            this.KID.Name = "KID";
            this.KID.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.KID.RangeEndValue = "";
            this.KID.RangeStartValue = "";
            this.KID.ReadOnly = true;
            this.KID.RegString = "";
            this.KID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.KID.ValidationErrorMsg = "";
            this.KID.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            this.KID.Visible = false;
            // 
            // subDocNum
            // 
            this.subDocNum.Alterable = true;
            this.subDocNum.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subDocNum.DefaultCellStyle = dataGridViewCellStyle27;
            this.subDocNum.HeaderText = "子物料搬运单号";
            this.subDocNum.IgnoreValueChanged = false;
            this.subDocNum.IndexOrder = 0;
            this.subDocNum.IsShowTimePick = false;
            this.subDocNum.LovParameter = null;
            this.subDocNum.MustBeInput = false;
            this.subDocNum.MustBeInputErrorMsg = "";
            this.subDocNum.Name = "subDocNum";
            this.subDocNum.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.subDocNum.RangeEndValue = "";
            this.subDocNum.RangeStartValue = "";
            this.subDocNum.ReadOnly = true;
            this.subDocNum.RegString = "";
            this.subDocNum.ValidationErrorMsg = "";
            this.subDocNum.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // docNum
            // 
            this.docNum.Alterable = true;
            this.docNum.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.WhiteSmoke;
            this.docNum.DefaultCellStyle = dataGridViewCellStyle28;
            this.docNum.HeaderText = "物料搬运单号";
            this.docNum.IgnoreValueChanged = false;
            this.docNum.IndexOrder = 0;
            this.docNum.IsShowTimePick = false;
            this.docNum.LovParameter = null;
            this.docNum.MustBeInput = false;
            this.docNum.MustBeInputErrorMsg = "";
            this.docNum.Name = "docNum";
            this.docNum.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.docNum.RangeEndValue = "";
            this.docNum.RangeStartValue = "";
            this.docNum.ReadOnly = true;
            this.docNum.RegString = "";
            this.docNum.ValidationErrorMsg = "";
            this.docNum.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // rownum
            // 
            this.rownum.Alterable = true;
            this.rownum.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rownum.DefaultCellStyle = dataGridViewCellStyle29;
            this.rownum.HeaderText = "行号";
            this.rownum.IgnoreValueChanged = false;
            this.rownum.IndexOrder = 0;
            this.rownum.IsShowTimePick = false;
            this.rownum.LovParameter = null;
            this.rownum.MustBeInput = false;
            this.rownum.MustBeInputErrorMsg = "";
            this.rownum.Name = "rownum";
            this.rownum.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.rownum.RangeEndValue = "";
            this.rownum.RangeStartValue = "";
            this.rownum.ReadOnly = true;
            this.rownum.RegString = "";
            this.rownum.ValidationErrorMsg = "";
            this.rownum.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // docType
            // 
            this.docType.Alterable = true;
            this.docType.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.WhiteSmoke;
            this.docType.DefaultCellStyle = dataGridViewCellStyle30;
            this.docType.HeaderText = "类型";
            this.docType.IgnoreValueChanged = false;
            this.docType.IndexOrder = 0;
            this.docType.IsShowTimePick = false;
            this.docType.LovParameter = null;
            this.docType.MustBeInput = false;
            this.docType.MustBeInputErrorMsg = "";
            this.docType.Name = "docType";
            this.docType.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.docType.RangeEndValue = "";
            this.docType.RangeStartValue = "";
            this.docType.ReadOnly = true;
            this.docType.RegString = "";
            this.docType.ValidationErrorMsg = "";
            this.docType.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // salesOrderNum
            // 
            this.salesOrderNum.Alterable = true;
            this.salesOrderNum.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.WhiteSmoke;
            this.salesOrderNum.DefaultCellStyle = dataGridViewCellStyle31;
            this.salesOrderNum.HeaderText = "销售订单号";
            this.salesOrderNum.IgnoreValueChanged = false;
            this.salesOrderNum.IndexOrder = 0;
            this.salesOrderNum.IsShowTimePick = false;
            this.salesOrderNum.LovParameter = null;
            this.salesOrderNum.MustBeInput = false;
            this.salesOrderNum.MustBeInputErrorMsg = "";
            this.salesOrderNum.Name = "salesOrderNum";
            this.salesOrderNum.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.salesOrderNum.RangeEndValue = "";
            this.salesOrderNum.RangeStartValue = "";
            this.salesOrderNum.ReadOnly = true;
            this.salesOrderNum.RegString = "";
            this.salesOrderNum.ValidationErrorMsg = "";
            this.salesOrderNum.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // salesOrderLineNum
            // 
            this.salesOrderLineNum.Alterable = true;
            this.salesOrderLineNum.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.WhiteSmoke;
            this.salesOrderLineNum.DefaultCellStyle = dataGridViewCellStyle32;
            this.salesOrderLineNum.HeaderText = "销售订单行号";
            this.salesOrderLineNum.IgnoreValueChanged = false;
            this.salesOrderLineNum.IndexOrder = 0;
            this.salesOrderLineNum.IsShowTimePick = false;
            this.salesOrderLineNum.LovParameter = null;
            this.salesOrderLineNum.MustBeInput = false;
            this.salesOrderLineNum.MustBeInputErrorMsg = "";
            this.salesOrderLineNum.Name = "salesOrderLineNum";
            this.salesOrderLineNum.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.salesOrderLineNum.RangeEndValue = "";
            this.salesOrderLineNum.RangeStartValue = "";
            this.salesOrderLineNum.ReadOnly = true;
            this.salesOrderLineNum.RegString = "";
            this.salesOrderLineNum.ValidationErrorMsg = "";
            this.salesOrderLineNum.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // plant_name
            // 
            this.plant_name.Alterable = true;
            this.plant_name.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plant_name.DefaultCellStyle = dataGridViewCellStyle33;
            this.plant_name.HeaderText = "工厂";
            this.plant_name.IgnoreValueChanged = false;
            this.plant_name.IndexOrder = 0;
            this.plant_name.IsShowTimePick = false;
            this.plant_name.LovParameter = null;
            this.plant_name.MustBeInput = false;
            this.plant_name.MustBeInputErrorMsg = "";
            this.plant_name.Name = "plant_name";
            this.plant_name.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.plant_name.RangeEndValue = "";
            this.plant_name.RangeStartValue = "";
            this.plant_name.ReadOnly = true;
            this.plant_name.RegString = "";
            this.plant_name.ValidationErrorMsg = "";
            this.plant_name.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // itemNum
            // 
            this.itemNum.Alterable = true;
            this.itemNum.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.WhiteSmoke;
            this.itemNum.DefaultCellStyle = dataGridViewCellStyle34;
            this.itemNum.HeaderText = "物料编码";
            this.itemNum.IgnoreValueChanged = false;
            this.itemNum.IndexOrder = 0;
            this.itemNum.IsShowTimePick = false;
            this.itemNum.LovParameter = null;
            this.itemNum.MustBeInput = false;
            this.itemNum.MustBeInputErrorMsg = "";
            this.itemNum.Name = "itemNum";
            this.itemNum.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.itemNum.RangeEndValue = "";
            this.itemNum.RangeStartValue = "";
            this.itemNum.ReadOnly = true;
            this.itemNum.RegString = "";
            this.itemNum.ValidationErrorMsg = "";
            this.itemNum.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // itemDesc
            // 
            this.itemDesc.Alterable = true;
            this.itemDesc.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.WhiteSmoke;
            this.itemDesc.DefaultCellStyle = dataGridViewCellStyle35;
            this.itemDesc.HeaderText = "物料说明";
            this.itemDesc.IgnoreValueChanged = false;
            this.itemDesc.IndexOrder = 0;
            this.itemDesc.IsShowTimePick = false;
            this.itemDesc.LovParameter = null;
            this.itemDesc.MustBeInput = false;
            this.itemDesc.MustBeInputErrorMsg = "";
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.itemDesc.RangeEndValue = "";
            this.itemDesc.RangeStartValue = "";
            this.itemDesc.ReadOnly = true;
            this.itemDesc.RegString = "";
            this.itemDesc.ValidationErrorMsg = "";
            this.itemDesc.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // pictureNum
            // 
            this.pictureNum.Alterable = true;
            this.pictureNum.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureNum.DefaultCellStyle = dataGridViewCellStyle36;
            this.pictureNum.HeaderText = "图号";
            this.pictureNum.IgnoreValueChanged = false;
            this.pictureNum.IndexOrder = 0;
            this.pictureNum.IsShowTimePick = false;
            this.pictureNum.LovParameter = null;
            this.pictureNum.MustBeInput = false;
            this.pictureNum.MustBeInputErrorMsg = "";
            this.pictureNum.Name = "pictureNum";
            this.pictureNum.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.pictureNum.RangeEndValue = "";
            this.pictureNum.RangeStartValue = "";
            this.pictureNum.ReadOnly = true;
            this.pictureNum.RegString = "";
            this.pictureNum.ValidationErrorMsg = "";
            this.pictureNum.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // requestQty
            // 
            this.requestQty.Alterable = true;
            this.requestQty.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.WhiteSmoke;
            this.requestQty.DefaultCellStyle = dataGridViewCellStyle37;
            this.requestQty.HeaderText = "请求数量";
            this.requestQty.IgnoreValueChanged = false;
            this.requestQty.IndexOrder = 0;
            this.requestQty.IsShowTimePick = false;
            this.requestQty.LovParameter = null;
            this.requestQty.MustBeInput = false;
            this.requestQty.MustBeInputErrorMsg = "";
            this.requestQty.Name = "requestQty";
            this.requestQty.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.requestQty.RangeEndValue = "";
            this.requestQty.RangeStartValue = "";
            this.requestQty.ReadOnly = true;
            this.requestQty.RegString = "";
            this.requestQty.ValidationErrorMsg = "";
            this.requestQty.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            this.requestQty.Visible = false;
            // 
            // quantity
            // 
            this.quantity.Alterable = true;
            this.quantity.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle38;
            this.quantity.HeaderText = "数量";
            this.quantity.IgnoreValueChanged = false;
            this.quantity.IndexOrder = 0;
            this.quantity.IsShowTimePick = false;
            this.quantity.LovParameter = null;
            this.quantity.MustBeInput = false;
            this.quantity.MustBeInputErrorMsg = "";
            this.quantity.Name = "quantity";
            this.quantity.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.quantity.RangeEndValue = "";
            this.quantity.RangeStartValue = "";
            this.quantity.ReadOnly = true;
            this.quantity.RegString = "";
            this.quantity.ValidationErrorMsg = "";
            this.quantity.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // totalScanQty
            // 
            this.totalScanQty.Alterable = true;
            this.totalScanQty.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalScanQty.DefaultCellStyle = dataGridViewCellStyle39;
            this.totalScanQty.HeaderText = "已扫描数量";
            this.totalScanQty.IgnoreValueChanged = false;
            this.totalScanQty.IndexOrder = 0;
            this.totalScanQty.IsShowTimePick = false;
            this.totalScanQty.LovParameter = null;
            this.totalScanQty.MustBeInput = false;
            this.totalScanQty.MustBeInputErrorMsg = "";
            this.totalScanQty.Name = "totalScanQty";
            this.totalScanQty.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.totalScanQty.RangeEndValue = "";
            this.totalScanQty.RangeStartValue = "";
            this.totalScanQty.ReadOnly = true;
            this.totalScanQty.RegString = "";
            this.totalScanQty.ValidationErrorMsg = "";
            this.totalScanQty.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // uom
            // 
            this.uom.Alterable = true;
            this.uom.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uom.DefaultCellStyle = dataGridViewCellStyle40;
            this.uom.HeaderText = "单位";
            this.uom.IgnoreValueChanged = false;
            this.uom.IndexOrder = 0;
            this.uom.IsShowTimePick = false;
            this.uom.LovParameter = null;
            this.uom.MustBeInput = false;
            this.uom.MustBeInputErrorMsg = "";
            this.uom.Name = "uom";
            this.uom.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.uom.RangeEndValue = "";
            this.uom.RangeStartValue = "";
            this.uom.ReadOnly = true;
            this.uom.RegString = "";
            this.uom.ValidationErrorMsg = "";
            this.uom.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // price
            // 
            this.price.Alterable = true;
            this.price.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.WhiteSmoke;
            this.price.DefaultCellStyle = dataGridViewCellStyle41;
            this.price.HeaderText = "单价";
            this.price.IgnoreValueChanged = false;
            this.price.IndexOrder = 0;
            this.price.IsShowTimePick = false;
            this.price.LovParameter = null;
            this.price.MustBeInput = false;
            this.price.MustBeInputErrorMsg = "";
            this.price.Name = "price";
            this.price.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.price.RangeEndValue = "";
            this.price.RangeStartValue = "";
            this.price.ReadOnly = true;
            this.price.RegString = "";
            this.price.ValidationErrorMsg = "";
            this.price.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // custom
            // 
            this.custom.Alterable = true;
            this.custom.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.WhiteSmoke;
            this.custom.DefaultCellStyle = dataGridViewCellStyle42;
            this.custom.HeaderText = "客户";
            this.custom.IgnoreValueChanged = false;
            this.custom.IndexOrder = 0;
            this.custom.IsShowTimePick = false;
            this.custom.LovParameter = null;
            this.custom.MustBeInput = false;
            this.custom.MustBeInputErrorMsg = "";
            this.custom.Name = "custom";
            this.custom.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.custom.RangeEndValue = "";
            this.custom.RangeStartValue = "";
            this.custom.ReadOnly = true;
            this.custom.RegString = "";
            this.custom.ValidationErrorMsg = "";
            this.custom.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // customSite
            // 
            this.customSite.Alterable = true;
            this.customSite.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customSite.DefaultCellStyle = dataGridViewCellStyle43;
            this.customSite.HeaderText = "客户地点";
            this.customSite.IgnoreValueChanged = false;
            this.customSite.IndexOrder = 0;
            this.customSite.IsShowTimePick = false;
            this.customSite.LovParameter = null;
            this.customSite.MustBeInput = false;
            this.customSite.MustBeInputErrorMsg = "";
            this.customSite.Name = "customSite";
            this.customSite.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.customSite.RangeEndValue = "";
            this.customSite.RangeStartValue = "";
            this.customSite.ReadOnly = true;
            this.customSite.RegString = "";
            this.customSite.ValidationErrorMsg = "";
            this.customSite.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // storeGroup
            // 
            this.storeGroup.Alterable = true;
            this.storeGroup.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.WhiteSmoke;
            this.storeGroup.DefaultCellStyle = dataGridViewCellStyle44;
            this.storeGroup.HeaderText = "仓储组";
            this.storeGroup.IgnoreValueChanged = false;
            this.storeGroup.IndexOrder = 0;
            this.storeGroup.IsShowTimePick = false;
            this.storeGroup.LovParameter = null;
            this.storeGroup.MustBeInput = false;
            this.storeGroup.MustBeInputErrorMsg = "";
            this.storeGroup.Name = "storeGroup";
            this.storeGroup.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.storeGroup.RangeEndValue = "";
            this.storeGroup.RangeStartValue = "";
            this.storeGroup.ReadOnly = true;
            this.storeGroup.RegString = "";
            this.storeGroup.ValidationErrorMsg = "";
            this.storeGroup.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // subinv
            // 
            this.subinv.Alterable = true;
            this.subinv.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subinv.DefaultCellStyle = dataGridViewCellStyle45;
            this.subinv.HeaderText = "子库存";
            this.subinv.IgnoreValueChanged = false;
            this.subinv.IndexOrder = 0;
            this.subinv.IsShowTimePick = false;
            this.subinv.LovParameter = null;
            this.subinv.MustBeInput = false;
            this.subinv.MustBeInputErrorMsg = "";
            this.subinv.Name = "subinv";
            this.subinv.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.subinv.RangeEndValue = "";
            this.subinv.RangeStartValue = "";
            this.subinv.ReadOnly = true;
            this.subinv.RegString = "";
            this.subinv.ValidationErrorMsg = "";
            this.subinv.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // locator
            // 
            this.locator.Alterable = true;
            this.locator.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.WhiteSmoke;
            this.locator.DefaultCellStyle = dataGridViewCellStyle46;
            this.locator.HeaderText = "货位";
            this.locator.IgnoreValueChanged = false;
            this.locator.IndexOrder = 0;
            this.locator.IsShowTimePick = false;
            this.locator.LovParameter = null;
            this.locator.MustBeInput = false;
            this.locator.MustBeInputErrorMsg = "";
            this.locator.Name = "locator";
            this.locator.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.locator.RangeEndValue = "";
            this.locator.RangeStartValue = "";
            this.locator.ReadOnly = true;
            this.locator.RegString = "";
            this.locator.ValidationErrorMsg = "";
            this.locator.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // targetSuninv
            // 
            this.targetSuninv.Alterable = true;
            this.targetSuninv.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.WhiteSmoke;
            this.targetSuninv.DefaultCellStyle = dataGridViewCellStyle47;
            this.targetSuninv.HeaderText = "移入子库";
            this.targetSuninv.IgnoreValueChanged = false;
            this.targetSuninv.IndexOrder = 0;
            this.targetSuninv.IsShowTimePick = false;
            this.targetSuninv.LovParameter = null;
            this.targetSuninv.MustBeInput = false;
            this.targetSuninv.MustBeInputErrorMsg = "";
            this.targetSuninv.Name = "targetSuninv";
            this.targetSuninv.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.targetSuninv.RangeEndValue = "";
            this.targetSuninv.RangeStartValue = "";
            this.targetSuninv.ReadOnly = true;
            this.targetSuninv.RegString = "";
            this.targetSuninv.ValidationErrorMsg = "";
            this.targetSuninv.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // targetLocator
            // 
            this.targetLocator.Alterable = true;
            this.targetLocator.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.WhiteSmoke;
            this.targetLocator.DefaultCellStyle = dataGridViewCellStyle48;
            this.targetLocator.HeaderText = "移入货位";
            this.targetLocator.IgnoreValueChanged = false;
            this.targetLocator.IndexOrder = 0;
            this.targetLocator.IsShowTimePick = false;
            this.targetLocator.LovParameter = null;
            this.targetLocator.MustBeInput = false;
            this.targetLocator.MustBeInputErrorMsg = "";
            this.targetLocator.Name = "targetLocator";
            this.targetLocator.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.targetLocator.RangeEndValue = "";
            this.targetLocator.RangeStartValue = "";
            this.targetLocator.ReadOnly = true;
            this.targetLocator.RegString = "";
            this.targetLocator.ValidationErrorMsg = "";
            this.targetLocator.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // process_erp_flag
            // 
            this.process_erp_flag.Alterable = true;
            this.process_erp_flag.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.WhiteSmoke;
            this.process_erp_flag.DefaultCellStyle = dataGridViewCellStyle49;
            this.process_erp_flag.HeaderText = "回传ERP状态";
            this.process_erp_flag.IgnoreValueChanged = false;
            this.process_erp_flag.IndexOrder = 0;
            this.process_erp_flag.IsShowTimePick = false;
            this.process_erp_flag.LovParameter = null;
            this.process_erp_flag.MustBeInput = false;
            this.process_erp_flag.MustBeInputErrorMsg = "";
            this.process_erp_flag.Name = "process_erp_flag";
            this.process_erp_flag.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.process_erp_flag.RangeEndValue = "";
            this.process_erp_flag.RangeStartValue = "";
            this.process_erp_flag.ReadOnly = true;
            this.process_erp_flag.RegString = "";
            this.process_erp_flag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.process_erp_flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.process_erp_flag.ValidationErrorMsg = "";
            this.process_erp_flag.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // process_message
            // 
            this.process_message.Alterable = true;
            this.process_message.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.WhiteSmoke;
            this.process_message.DefaultCellStyle = dataGridViewCellStyle50;
            this.process_message.HeaderText = "回传信息";
            this.process_message.IgnoreValueChanged = false;
            this.process_message.IndexOrder = 0;
            this.process_message.IsShowTimePick = false;
            this.process_message.LovParameter = null;
            this.process_message.MustBeInput = false;
            this.process_message.MustBeInputErrorMsg = "";
            this.process_message.Name = "process_message";
            this.process_message.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.process_message.RangeEndValue = "";
            this.process_message.RangeStartValue = "";
            this.process_message.ReadOnly = true;
            this.process_message.RegString = "";
            this.process_message.ValidationErrorMsg = "";
            this.process_message.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigatorEx1.CancelAddRowEvent = false;
            this.navigatorEx1.Context = windowsFormsSynchronizationContext2;
            this.navigatorEx1.DelsqlList = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.DelsqlList")));
            this.navigatorEx1.InsertSqlList = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.InsertSqlList")));
            this.navigatorEx1.IsUserControlStatusMsg = false;
            this.navigatorEx1.LastAddRowIndex = -1;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx1.Name = "navigatorEx1";
            this.navigatorEx1.QueryRowsCountSql = "";
            this.navigatorEx1.QuerySql = "";
            this.navigatorEx1.ShowAddBtn = false;
            this.navigatorEx1.ShowChooseAllBtn = false;
            this.navigatorEx1.ShowClearBtn = false;
            this.navigatorEx1.ShowDelBtn = false;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowQueryBtn = true;
            this.navigatorEx1.ShowSaveBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(1018, 30);
            this.navigatorEx1.SqlExecuteResult = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.SqlExecuteResult")));
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.TbAbbreviated = "";
            this.navigatorEx1.UpdateSqlList = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.UpdateSqlList")));
            this.navigatorEx1.OnQuery += new Mes.Core.ApplicationObject.SystemNavigatorClickedEventHandler(this.MainForm_OnQuery);
            this.navigatorEx1.Load += new System.EventHandler(this.navigatorEx1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 555);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "物料搬运单查询";
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Mes.ControlsEx.PanelEx panelEx1;
        private Mes.ControlsEx.NavigatorEx navigatorEx1;
        private Mes.ControlsEx.StatusStripBarEx statusStripBarEx1;
        private Mes.ControlsEx.DataGridViewEx dataGridViewEx1;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn KID;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn subDocNum;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn docNum;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn rownum;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn docType;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn salesOrderNum;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn salesOrderLineNum;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn plant_name;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn itemNum;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn itemDesc;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn pictureNum;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn requestQty;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn quantity;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn totalScanQty;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn uom;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn price;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn custom;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn customSite;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn storeGroup;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn subinv;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn locator;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn targetSuninv;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn targetLocator;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn process_erp_flag;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn process_message;
    }
}