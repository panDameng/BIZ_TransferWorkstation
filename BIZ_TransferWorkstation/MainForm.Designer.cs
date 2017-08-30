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
            Mes.ControlsEx.Class.ORM orm1 = new Mes.ControlsEx.Class.ORM();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.panelEx1 = new Mes.ControlsEx.PanelEx(this.components);
            this.statusStripBarEx1 = new Mes.ControlsEx.StatusStripBarEx();
            this.dataGridViewEx1 = new Mes.ControlsEx.DataGridViewEx(this.components);
            this.KID = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.subDocNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.docNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.rownum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.docType = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.barCode = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.pictureNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.partProcessNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.shortCode = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.salesOrderNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.salesTime = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.sourceOwner = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.sourceOwnerSite = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.owner = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            this.ownerSite = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.salesOrderNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.salesOrderLineNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.plant_name = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.itemNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
           // this.itemDesc = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
           // this.pictureNum = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.requestQty = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.quantity = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.totalScanQty = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.uom = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.price = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.custom = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.customSite = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.storeGroup = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.subinv = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.locator = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.targetSuninv = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.targetLocator = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.process_erp_flag = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
            //this.process_message = new Mes.ControlsEx.DataGridViewTextBoxExColumn(this.components);
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
            //this.subDocNum,
            //this.docNum,
            //this.rownum,
            //this.docType,
            this.barCode,
            this.pictureNum,
            this.partProcessNum,
            this.shortCode,
            this.salesOrderNum,
            this.salesTime,
            this.sourceOwner,
            this.sourceOwnerSite,
            this.owner,
            this.ownerSite
            //this.salesOrderLineNum,
            //this.plant_name,
            //this.itemNum,
            //this.itemDesc,
                //this.requestQty,
                //this.quantity,
                //this.totalScanQty,
                //this.uom,
                //this.price,
                //this.custom,
                //this.customSite,
                //this.storeGroup,
                //this.subinv,
                //this.locator,
                //this.targetSuninv,
                //this.targetLocator,
                //this.process_erp_flag,
                //this.process_message
            });
            orm1.ColumnCommPropertyList = "";
            orm1.DelSqlTemplate = "";
            orm1.InsertSqlTemplate = "";
            orm1.PrimaryTable = "";
            orm1.SelectSqlTemplate = "";
            orm1.UpdateSqlTemplate = "";
            this.dataGridViewEx1.DBORM = orm1;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KID.DefaultCellStyle = dataGridViewCellStyle1;
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
            // barCode
            // 
            this.barCode.Alterable = true;
            this.barCode.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.barCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.barCode.HeaderText = "条码编号";
            this.barCode.IgnoreValueChanged = false;
            this.barCode.IndexOrder = 0;
            this.barCode.IsShowTimePick = false;
            this.barCode.LovParameter = null;
            this.barCode.MustBeInput = false;
            this.barCode.MustBeInputErrorMsg = "";
            this.barCode.Name = "barCode";
            this.barCode.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.barCode.RangeEndValue = "";
            this.barCode.RangeStartValue = "";
            this.barCode.ReadOnly = true;
            this.barCode.RegString = "";
            this.barCode.ValidationErrorMsg = "";
            this.barCode.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // pictureNum
            // 
            this.pictureNum.Alterable = true;
            this.pictureNum.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            this.pictureNum.IgnoreValueChanged = false;
            this.pictureNum.IndexOrder = 0;
            this.pictureNum.HeaderText = "图号";
            this.pictureNum.IsShowTimePick = false;
            this.pictureNum.LovParameter = null;
            this.pictureNum.MustBeInput = false;
            this.pictureNum.MustBeInputErrorMsg = "";
            this.pictureNum.Name = "pictureNum";
            this.pictureNum.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.pictureNum.RangeEndValue = "";
            this.pictureNum.RangeStartValue = "";
            this.pictureNum.RegString = "";
            this.pictureNum.ValidationErrorMsg = "";
            this.pictureNum.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // partProcessNum
            // 
            this.partProcessNum.Alterable = true;
            this.partProcessNum.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            this.partProcessNum.HeaderText = "零件加工编号";
            this.partProcessNum.IgnoreValueChanged = false;
            this.partProcessNum.IndexOrder = 0;
            this.partProcessNum.IsShowTimePick = false;
            this.partProcessNum.LovParameter = null;
            this.partProcessNum.MustBeInput = false;
            this.partProcessNum.MustBeInputErrorMsg = "";
            this.partProcessNum.Name = "partProcessNum";
            this.partProcessNum.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.partProcessNum.RangeEndValue = "";
            this.partProcessNum.RangeStartValue = "";
            this.partProcessNum.RegString = "";
            this.partProcessNum.ValidationErrorMsg = "";
            this.partProcessNum.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // shortCode
            // 
            this.shortCode.Alterable = true;
            this.shortCode.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            this.shortCode.HeaderText = "供应商三位码";
            this.shortCode.IgnoreValueChanged = false;
            this.shortCode.IndexOrder = 0;
            this.shortCode.IsShowTimePick = false;
            this.shortCode.LovParameter = null;
            this.shortCode.MustBeInput = false;
            this.shortCode.MustBeInputErrorMsg = "";
            this.shortCode.Name = "shortCode";
            this.shortCode.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.shortCode.RangeEndValue = "";
            this.shortCode.RangeStartValue = "";
            this.shortCode.RegString = "";
            this.shortCode.ValidationErrorMsg = "";
            this.shortCode.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // salesOrderNum
            // 
            this.salesOrderNum.Alterable = true;
            this.salesOrderNum.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.salesOrderNum.DefaultCellStyle = dataGridViewCellStyle3;
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
            // salesTime
            // 
            this.salesTime.Alterable = true;
            this.salesTime.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            this.salesTime.HeaderText = "销售时间";
            this.salesTime.IgnoreValueChanged = false;
            this.salesTime.IndexOrder = 0;
            this.salesTime.IsShowTimePick = false;
            this.salesTime.LovParameter = null;
            this.salesTime.MustBeInput = false;
            this.salesTime.MustBeInputErrorMsg = "";
            this.salesTime.Name = "salesTime";
            this.salesTime.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.salesTime.RangeEndValue = "";
            this.salesTime.RangeStartValue = "";
            this.salesTime.RegString = "";
            this.salesTime.ValidationErrorMsg = "";
            this.salesTime.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // sourceOwner
            // 
            this.sourceOwner.Alterable = true;
            this.sourceOwner.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            this.sourceOwner.HeaderText = "来源交易方";
            this.sourceOwner.IgnoreValueChanged = false;
            this.sourceOwner.IndexOrder = 0;
            this.sourceOwner.IsShowTimePick = false;
            this.sourceOwner.LovParameter = null;
            this.sourceOwner.MustBeInput = false;
            this.sourceOwner.MustBeInputErrorMsg = "";
            this.sourceOwner.Name = "sourceOwner";
            this.sourceOwner.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.sourceOwner.RangeEndValue = "";
            this.sourceOwner.RangeStartValue = "";
            this.sourceOwner.RegString = "";
            this.sourceOwner.ValidationErrorMsg = "";
            this.sourceOwner.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // sourceOwnerSite
            // 
            this.sourceOwnerSite.Alterable = true;
            this.sourceOwnerSite.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            this.sourceOwnerSite.HeaderText = "来源交易方地址";
            this.sourceOwnerSite.IgnoreValueChanged = false;
            this.sourceOwnerSite.IndexOrder = 0;
            this.sourceOwnerSite.IsShowTimePick = false;
            this.sourceOwnerSite.LovParameter = null;
            this.sourceOwnerSite.MustBeInput = false;
            this.sourceOwnerSite.MustBeInputErrorMsg = "";
            this.sourceOwnerSite.Name = "sourceOwnerSite";
            this.sourceOwnerSite.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.sourceOwnerSite.RangeEndValue = "";
            this.sourceOwnerSite.RangeStartValue = "";
            this.sourceOwnerSite.RegString = "";
            this.sourceOwnerSite.ValidationErrorMsg = "";
            this.sourceOwnerSite.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // owner
            // 
            this.owner.Alterable = true;
            this.owner.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            this.owner.HeaderText = "交易方";
            this.owner.IgnoreValueChanged = false;
            this.owner.IndexOrder = 0;
            this.owner.IsShowTimePick = false;
            this.owner.LovParameter = null;
            this.owner.MustBeInput = false;
            this.owner.MustBeInputErrorMsg = "";
            this.owner.Name = "owner";
            this.owner.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.owner.RangeEndValue = "";
            this.owner.RangeStartValue = "";
            this.owner.RegString = "";
            this.owner.ValidationErrorMsg = "";
            this.owner.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // ownerSite
            // 
            this.ownerSite.Alterable = true;
            this.ownerSite.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            this.ownerSite.HeaderText = "交易方地址";
            this.ownerSite.IgnoreValueChanged = false;
            this.ownerSite.IndexOrder = 0;
            this.ownerSite.IsShowTimePick = false;
            this.ownerSite.LovParameter = null;
            this.ownerSite.MustBeInput = false;
            this.ownerSite.MustBeInputErrorMsg = "";
            this.ownerSite.Name = "ownerSite";
            this.ownerSite.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            this.ownerSite.RangeEndValue = "";
            this.ownerSite.RangeStartValue = "";
            this.ownerSite.RegString = "";
            this.ownerSite.ValidationErrorMsg = "";
            this.ownerSite.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// itemNum
            //// 
            //this.itemNum.Alterable = true;
            //this.itemNum.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //this.itemNum.IgnoreValueChanged = false;
            //this.itemNum.IndexOrder = 0;
            //this.itemNum.IsShowTimePick = false;
            //this.itemNum.LovParameter = null;
            //this.itemNum.MustBeInput = false;
            //this.itemNum.MustBeInputErrorMsg = "";
            //this.itemNum.Name = "itemNum";
            //this.itemNum.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.itemNum.RangeEndValue = "";
            //this.itemNum.RangeStartValue = "";
            //this.itemNum.RegString = "";
            //this.itemNum.ValidationErrorMsg = "";
            //this.itemNum.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// itemDesc
            //// 
            //this.itemDesc.Alterable = true;
            //this.itemDesc.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            //this.itemDesc.DefaultCellStyle = dataGridViewCellStyle4;
            //this.itemDesc.HeaderText = "物料说明";
            //this.itemDesc.IgnoreValueChanged = false;
            //this.itemDesc.IndexOrder = 0;
            //this.itemDesc.IsShowTimePick = false;
            //this.itemDesc.LovParameter = null;
            //this.itemDesc.MustBeInput = false;
            //this.itemDesc.MustBeInputErrorMsg = "";
            //this.itemDesc.Name = "itemDesc";
            //this.itemDesc.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.itemDesc.RangeEndValue = "";
            //this.itemDesc.RangeStartValue = "";
            //this.itemDesc.ReadOnly = true;
            //this.itemDesc.RegString = "";
            //this.itemDesc.ValidationErrorMsg = "";
            //this.itemDesc.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // pictureNum
            // 
            this.pictureNum.Alterable = true;
            this.pictureNum.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureNum.DefaultCellStyle = dataGridViewCellStyle5;
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
            //this.requestQty.Alterable = true;
            //this.requestQty.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //this.requestQty.IgnoreValueChanged = false;
            //this.requestQty.IndexOrder = 0;
            //this.requestQty.IsShowTimePick = false;
            //this.requestQty.LovParameter = null;
            //this.requestQty.MustBeInput = false;
            //this.requestQty.MustBeInputErrorMsg = "";
            //this.requestQty.Name = "requestQty";
            //this.requestQty.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.requestQty.RangeEndValue = "";
            //this.requestQty.RangeStartValue = "";
            //this.requestQty.RegString = "";
            //this.requestQty.ValidationErrorMsg = "";
            //this.requestQty.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// quantity
            //// 
            //this.quantity.Alterable = true;
            //this.quantity.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //this.quantity.IgnoreValueChanged = false;
            //this.quantity.IndexOrder = 0;
            //this.quantity.IsShowTimePick = false;
            //this.quantity.LovParameter = null;
            //this.quantity.MustBeInput = false;
            //this.quantity.MustBeInputErrorMsg = "";
            //this.quantity.Name = "quantity";
            //this.quantity.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.quantity.RangeEndValue = "";
            //this.quantity.RangeStartValue = "";
            //this.quantity.RegString = "";
            //this.quantity.ValidationErrorMsg = "";
            //this.quantity.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// totalScanQty
            //// 
            //this.totalScanQty.Alterable = true;
            //this.totalScanQty.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //this.totalScanQty.IgnoreValueChanged = false;
            //this.totalScanQty.IndexOrder = 0;
            //this.totalScanQty.IsShowTimePick = false;
            //this.totalScanQty.LovParameter = null;
            //this.totalScanQty.MustBeInput = false;
            //this.totalScanQty.MustBeInputErrorMsg = "";
            //this.totalScanQty.Name = "totalScanQty";
            //this.totalScanQty.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.totalScanQty.RangeEndValue = "";
            //this.totalScanQty.RangeStartValue = "";
            //this.totalScanQty.RegString = "";
            //this.totalScanQty.ValidationErrorMsg = "";
            //this.totalScanQty.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// uom
            //// 
            //this.uom.Alterable = true;
            //this.uom.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            //this.uom.DefaultCellStyle = dataGridViewCellStyle6;
            //this.uom.HeaderText = "单位";
            //this.uom.IgnoreValueChanged = false;
            //this.uom.IndexOrder = 0;
            //this.uom.IsShowTimePick = false;
            //this.uom.LovParameter = null;
            //this.uom.MustBeInput = false;
            //this.uom.MustBeInputErrorMsg = "";
            //this.uom.Name = "uom";
            //this.uom.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.uom.RangeEndValue = "";
            //this.uom.RangeStartValue = "";
            //this.uom.ReadOnly = true;
            //this.uom.RegString = "";
            //this.uom.ValidationErrorMsg = "";
            //this.uom.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // price
            // 
            //this.price.Alterable = true;
            //this.price.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            //this.price.DefaultCellStyle = dataGridViewCellStyle7;
            //this.price.HeaderText = "单价";
            //this.price.IgnoreValueChanged = false;
            //this.price.IndexOrder = 0;
            //this.price.IsShowTimePick = false;
            //this.price.LovParameter = null;
            //this.price.MustBeInput = false;
            //this.price.MustBeInputErrorMsg = "";
            //this.price.Name = "price";
            //this.price.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.price.RangeEndValue = "";
            //this.price.RangeStartValue = "";
            //this.price.ReadOnly = true;
            //this.price.RegString = "";
            //this.price.ValidationErrorMsg = "";
            //this.price.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// custom
            //// 
            //this.custom.Alterable = true;
            //this.custom.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //this.custom.IgnoreValueChanged = false;
            //this.custom.IndexOrder = 0;
            //this.custom.IsShowTimePick = false;
            //this.custom.LovParameter = null;
            //this.custom.MustBeInput = false;
            //this.custom.MustBeInputErrorMsg = "";
            //this.custom.Name = "custom";
            //this.custom.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.custom.RangeEndValue = "";
            //this.custom.RangeStartValue = "";
            //this.custom.RegString = "";
            //this.custom.ValidationErrorMsg = "";
            //this.custom.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// customSite
            //// 
            //this.customSite.Alterable = true;
            //this.customSite.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //this.customSite.IgnoreValueChanged = false;
            //this.customSite.IndexOrder = 0;
            //this.customSite.IsShowTimePick = false;
            //this.customSite.LovParameter = null;
            //this.customSite.MustBeInput = false;
            //this.customSite.MustBeInputErrorMsg = "";
            //this.customSite.Name = "customSite";
            //this.customSite.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.customSite.RangeEndValue = "";
            //this.customSite.RangeStartValue = "";
            //this.customSite.RegString = "";
            //this.customSite.ValidationErrorMsg = "";
            //this.customSite.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// storeGroup
            //// 
            //this.storeGroup.Alterable = true;
            //this.storeGroup.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //this.storeGroup.IgnoreValueChanged = false;
            //this.storeGroup.IndexOrder = 0;
            //this.storeGroup.IsShowTimePick = false;
            //this.storeGroup.LovParameter = null;
            //this.storeGroup.MustBeInput = false;
            //this.storeGroup.MustBeInputErrorMsg = "";
            //this.storeGroup.Name = "storeGroup";
            //this.storeGroup.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.storeGroup.RangeEndValue = "";
            //this.storeGroup.RangeStartValue = "";
            //this.storeGroup.RegString = "";
            //this.storeGroup.ValidationErrorMsg = "";
            //this.storeGroup.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// subinv
            //// 
            //this.subinv.Alterable = true;
            //this.subinv.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //this.subinv.IgnoreValueChanged = false;
            //this.subinv.IndexOrder = 0;
            //this.subinv.IsShowTimePick = false;
            //this.subinv.LovParameter = null;
            //this.subinv.MustBeInput = false;
            //this.subinv.MustBeInputErrorMsg = "";
            //this.subinv.Name = "subinv";
            //this.subinv.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.subinv.RangeEndValue = "";
            //this.subinv.RangeStartValue = "";
            //this.subinv.RegString = "";
            //this.subinv.ValidationErrorMsg = "";
            //this.subinv.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// locator
            //// 
            //this.locator.Alterable = true;
            //this.locator.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //this.locator.IgnoreValueChanged = false;
            //this.locator.IndexOrder = 0;
            //this.locator.IsShowTimePick = false;
            //this.locator.LovParameter = null;
            //this.locator.MustBeInput = false;
            //this.locator.MustBeInputErrorMsg = "";
            //this.locator.Name = "locator";
            //this.locator.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.locator.RangeEndValue = "";
            //this.locator.RangeStartValue = "";
            //this.locator.RegString = "";
            //this.locator.ValidationErrorMsg = "";
            //this.locator.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// targetSuninv
            //// 
            //this.targetSuninv.Alterable = true;
            //this.targetSuninv.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //this.targetSuninv.IgnoreValueChanged = false;
            //this.targetSuninv.IndexOrder = 0;
            //this.targetSuninv.IsShowTimePick = false;
            //this.targetSuninv.LovParameter = null;
            //this.targetSuninv.MustBeInput = false;
            //this.targetSuninv.MustBeInputErrorMsg = "";
            //this.targetSuninv.Name = "targetSuninv";
            //this.targetSuninv.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.targetSuninv.RangeEndValue = "";
            //this.targetSuninv.RangeStartValue = "";
            //this.targetSuninv.RegString = "";
            //this.targetSuninv.ValidationErrorMsg = "";
            //this.targetSuninv.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// targetLocator
            //// 
            //this.targetLocator.Alterable = true;
            //this.targetLocator.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //this.targetLocator.IgnoreValueChanged = false;
            //this.targetLocator.IndexOrder = 0;
            //this.targetLocator.IsShowTimePick = false;
            //this.targetLocator.LovParameter = null;
            //this.targetLocator.MustBeInput = false;
            //this.targetLocator.MustBeInputErrorMsg = "";
            //this.targetLocator.Name = "targetLocator";
            //this.targetLocator.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.targetLocator.RangeEndValue = "";
            //this.targetLocator.RangeStartValue = "";
            //this.targetLocator.RegString = "";
            //this.targetLocator.ValidationErrorMsg = "";
            //this.targetLocator.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// process_erp_flag
            //// 
            //this.process_erp_flag.Alterable = true;
            //this.process_erp_flag.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //this.process_erp_flag.IgnoreValueChanged = false;
            //this.process_erp_flag.IndexOrder = 0;
            //this.process_erp_flag.IsShowTimePick = false;
            //this.process_erp_flag.LovParameter = null;
            //this.process_erp_flag.MustBeInput = false;
            //this.process_erp_flag.MustBeInputErrorMsg = "";
            //this.process_erp_flag.Name = "process_erp_flag";
            //this.process_erp_flag.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.process_erp_flag.RangeEndValue = "";
            //this.process_erp_flag.RangeStartValue = "";
            //this.process_erp_flag.RegString = "";
            //this.process_erp_flag.ValidationErrorMsg = "";
            //this.process_erp_flag.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            //// 
            //// process_message
            //// 
            //this.process_message.Alterable = true;
            //this.process_message.DataType = Mes.Core.ApplicationObject.DataGridViewColumnDataType.NONE;
            //this.process_message.IgnoreValueChanged = false;
            //this.process_message.IndexOrder = 0;
            //this.process_message.IsShowTimePick = false;
            //this.process_message.LovParameter = null;
            //this.process_message.MustBeInput = false;
            //this.process_message.MustBeInputErrorMsg = "";
            //this.process_message.Name = "process_message";
            //this.process_message.PopType = Mes.Core.ApplicationObject.DataGridViewColumnPopType.NONE;
            //this.process_message.RangeEndValue = "";
            //this.process_message.RangeStartValue = "";
            //this.process_message.RegString = "";
            //this.process_message.ValidationErrorMsg = "";
            //this.process_message.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigatorEx1.CancelAddRowEvent = false;
            this.navigatorEx1.Context = windowsFormsSynchronizationContext1;
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
        private Mes.ControlsEx.DataGridViewTextBoxExColumn barCode;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn pictureNum;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn partProcessNum;//零件加工编号
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn subDocNum;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn docNum;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn rownum;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn docType;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn shortCode;//供应商三位码

        private Mes.ControlsEx.DataGridViewTextBoxExColumn salesOrderNum;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn salesTime;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn sourceOwner;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn sourceOwnerSite;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn owner;
        private Mes.ControlsEx.DataGridViewTextBoxExColumn ownerSite;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn salesOrderLineNum;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn plant_name;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn itemNum;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn itemDesc;

        //private Mes.ControlsEx.DataGridViewTextBoxExColumn requestQty;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn quantity;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn totalScanQty;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn uom;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn price;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn custom;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn customSite;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn storeGroup;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn subinv;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn locator;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn targetSuninv;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn targetLocator;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn process_erp_flag;
        //private Mes.ControlsEx.DataGridViewTextBoxExColumn process_message;
    }
}