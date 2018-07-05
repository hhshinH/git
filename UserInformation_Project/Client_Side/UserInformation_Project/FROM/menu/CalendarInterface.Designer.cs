namespace UserInformation_Project.FROM.menu
{
	partial class CalendarInterface
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
			DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
			DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
			DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
			this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
			this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController();
			this.activeViewBar1 = new DevExpress.XtraScheduler.UI.ActiveViewBar();
			this.switchToDayViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToDayViewItem();
			this.switchToWorkWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem();
			this.switchToWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWeekViewItem();
			this.switchToFullWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem();
			this.switchToMonthViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToMonthViewItem();
			this.switchToTimelineViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem();
			this.switchToGanttViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToGanttViewItem();
			this.switchToAgendaViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem();
			this.timeScaleBar1 = new DevExpress.XtraScheduler.UI.TimeScaleBar();
			this.switchTimeScalesItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesItem();
			this.changeScaleWidthItem1 = new DevExpress.XtraScheduler.UI.ChangeScaleWidthItem();
			this.switchTimeScalesCaptionItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem();
			this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
			this.layoutBar1 = new DevExpress.XtraScheduler.UI.LayoutBar();
			this.switchCompressWeekendItem1 = new DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem();
			this.switchShowWorkTimeOnlyItem1 = new DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem();
			this.switchCellsAutoHeightItem1 = new DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem();
			this.changeSnapToCellsUIItem1 = new DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem();
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
			this.SuspendLayout();
			// 
			// schedulerControl1
			// 
			this.schedulerControl1.DataStorage = this.schedulerStorage1;
			this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.schedulerControl1.Location = new System.Drawing.Point(0, 62);
			this.schedulerControl1.MenuManager = this.barManager1;
			this.schedulerControl1.Name = "schedulerControl1";
			this.schedulerControl1.Size = new System.Drawing.Size(986, 466);
			this.schedulerControl1.Start = new System.DateTime(2018, 6, 26, 0, 0, 0, 0);
			this.schedulerControl1.TabIndex = 0;
			this.schedulerControl1.Text = "schedulerControl1";
			this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
			this.schedulerControl1.Views.FullWeekView.Enabled = true;
			this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
			this.schedulerControl1.Views.WorkWeekView.Enabled = false;
			this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.activeViewBar1,
            this.timeScaleBar1,
            this.layoutBar1});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.switchToDayViewItem1,
            this.switchToWorkWeekViewItem1,
            this.switchToWeekViewItem1,
            this.switchToFullWeekViewItem1,
            this.switchToMonthViewItem1,
            this.switchToTimelineViewItem1,
            this.switchToGanttViewItem1,
            this.switchToAgendaViewItem1,
            this.switchTimeScalesItem1,
            this.changeScaleWidthItem1,
            this.switchTimeScalesCaptionItem1,
            this.switchCompressWeekendItem1,
            this.switchShowWorkTimeOnlyItem1,
            this.switchCellsAutoHeightItem1,
            this.changeSnapToCellsUIItem1});
			this.barManager1.MaxItemId = 15;
			this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(986, 62);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 528);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(986, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 62);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 466);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(986, 62);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 466);
			// 
			// schedulerBarController1
			// 
			this.schedulerBarController1.BarItems.Add(this.switchToDayViewItem1);
			this.schedulerBarController1.BarItems.Add(this.switchToWorkWeekViewItem1);
			this.schedulerBarController1.BarItems.Add(this.switchToWeekViewItem1);
			this.schedulerBarController1.BarItems.Add(this.switchToFullWeekViewItem1);
			this.schedulerBarController1.BarItems.Add(this.switchToMonthViewItem1);
			this.schedulerBarController1.BarItems.Add(this.switchToTimelineViewItem1);
			this.schedulerBarController1.BarItems.Add(this.switchToGanttViewItem1);
			this.schedulerBarController1.BarItems.Add(this.switchToAgendaViewItem1);
			this.schedulerBarController1.BarItems.Add(this.switchTimeScalesItem1);
			this.schedulerBarController1.BarItems.Add(this.changeScaleWidthItem1);
			this.schedulerBarController1.BarItems.Add(this.switchTimeScalesCaptionItem1);
			this.schedulerBarController1.BarItems.Add(this.switchCompressWeekendItem1);
			this.schedulerBarController1.BarItems.Add(this.switchShowWorkTimeOnlyItem1);
			this.schedulerBarController1.BarItems.Add(this.switchCellsAutoHeightItem1);
			this.schedulerBarController1.BarItems.Add(this.changeSnapToCellsUIItem1);
			this.schedulerBarController1.Control = this.schedulerControl1;
			// 
			// activeViewBar1
			// 
			this.activeViewBar1.Control = this.schedulerControl1;
			this.activeViewBar1.DockCol = 0;
			this.activeViewBar1.DockRow = 0;
			this.activeViewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.activeViewBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToDayViewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToWorkWeekViewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToWeekViewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToFullWeekViewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToMonthViewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToTimelineViewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToGanttViewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToAgendaViewItem1)});
			// 
			// switchToDayViewItem1
			// 
			this.switchToDayViewItem1.Id = 0;
			this.switchToDayViewItem1.Name = "switchToDayViewItem1";
			// 
			// switchToWorkWeekViewItem1
			// 
			this.switchToWorkWeekViewItem1.Id = 1;
			this.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1";
			// 
			// switchToWeekViewItem1
			// 
			this.switchToWeekViewItem1.Id = 2;
			this.switchToWeekViewItem1.Name = "switchToWeekViewItem1";
			// 
			// switchToFullWeekViewItem1
			// 
			this.switchToFullWeekViewItem1.Id = 3;
			this.switchToFullWeekViewItem1.Name = "switchToFullWeekViewItem1";
			// 
			// switchToMonthViewItem1
			// 
			this.switchToMonthViewItem1.Id = 4;
			this.switchToMonthViewItem1.Name = "switchToMonthViewItem1";
			// 
			// switchToTimelineViewItem1
			// 
			this.switchToTimelineViewItem1.Id = 5;
			this.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1";
			// 
			// switchToGanttViewItem1
			// 
			this.switchToGanttViewItem1.Id = 6;
			this.switchToGanttViewItem1.Name = "switchToGanttViewItem1";
			// 
			// switchToAgendaViewItem1
			// 
			this.switchToAgendaViewItem1.Id = 7;
			this.switchToAgendaViewItem1.Name = "switchToAgendaViewItem1";
			// 
			// timeScaleBar1
			// 
			this.timeScaleBar1.Control = this.schedulerControl1;
			this.timeScaleBar1.DockCol = 0;
			this.timeScaleBar1.DockRow = 1;
			this.timeScaleBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.timeScaleBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.switchTimeScalesItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeScaleWidthItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchTimeScalesCaptionItem1)});
			// 
			// switchTimeScalesItem1
			// 
			this.switchTimeScalesItem1.Id = 8;
			this.switchTimeScalesItem1.Name = "switchTimeScalesItem1";
			// 
			// changeScaleWidthItem1
			// 
			this.changeScaleWidthItem1.Edit = this.repositoryItemSpinEdit1;
			this.changeScaleWidthItem1.Id = 9;
			this.changeScaleWidthItem1.Name = "changeScaleWidthItem1";
			this.changeScaleWidthItem1.UseCommandCaption = true;
			// 
			// switchTimeScalesCaptionItem1
			// 
			this.switchTimeScalesCaptionItem1.Id = 10;
			this.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1";
			// 
			// repositoryItemSpinEdit1
			// 
			this.repositoryItemSpinEdit1.AutoHeight = false;
			this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
			this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
			// 
			// layoutBar1
			// 
			this.layoutBar1.Control = this.schedulerControl1;
			this.layoutBar1.DockCol = 1;
			this.layoutBar1.DockRow = 1;
			this.layoutBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.layoutBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.switchCompressWeekendItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchShowWorkTimeOnlyItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchCellsAutoHeightItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeSnapToCellsUIItem1)});
			// 
			// switchCompressWeekendItem1
			// 
			this.switchCompressWeekendItem1.Id = 11;
			this.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1";
			// 
			// switchShowWorkTimeOnlyItem1
			// 
			this.switchShowWorkTimeOnlyItem1.Id = 12;
			this.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1";
			// 
			// switchCellsAutoHeightItem1
			// 
			this.switchCellsAutoHeightItem1.Id = 13;
			this.switchCellsAutoHeightItem1.Name = "switchCellsAutoHeightItem1";
			// 
			// changeSnapToCellsUIItem1
			// 
			this.changeSnapToCellsUIItem1.Id = 14;
			this.changeSnapToCellsUIItem1.Name = "changeSnapToCellsUIItem1";
			// 
			// CalendarInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(986, 528);
			this.Controls.Add(this.schedulerControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "CalendarInterface";
			this.Text = "CalendarInterface";
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
		private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraScheduler.UI.ActiveViewBar activeViewBar1;
		private DevExpress.XtraScheduler.UI.SwitchToDayViewItem switchToDayViewItem1;
		private DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem switchToWorkWeekViewItem1;
		private DevExpress.XtraScheduler.UI.SwitchToWeekViewItem switchToWeekViewItem1;
		private DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem switchToFullWeekViewItem1;
		private DevExpress.XtraScheduler.UI.SwitchToMonthViewItem switchToMonthViewItem1;
		private DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem switchToTimelineViewItem1;
		private DevExpress.XtraScheduler.UI.SwitchToGanttViewItem switchToGanttViewItem1;
		private DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem switchToAgendaViewItem1;
		private DevExpress.XtraScheduler.UI.TimeScaleBar timeScaleBar1;
		private DevExpress.XtraScheduler.UI.SwitchTimeScalesItem switchTimeScalesItem1;
		private DevExpress.XtraScheduler.UI.ChangeScaleWidthItem changeScaleWidthItem1;
		private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
		private DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem switchTimeScalesCaptionItem1;
		private DevExpress.XtraScheduler.UI.LayoutBar layoutBar1;
		private DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem switchCompressWeekendItem1;
		private DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem switchShowWorkTimeOnlyItem1;
		private DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem switchCellsAutoHeightItem1;
		private DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem changeSnapToCellsUIItem1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraScheduler.UI.SchedulerBarController schedulerBarController1;
	}
}