using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace WinDesignerDashboardState
{
    public partial class DesignerForm1: DevExpress.XtraBars.Ribbon.RibbonForm {
        const string path = @"..\..\Dashboards\dashboardWithSavedState.xml";
        public DesignerForm1() {
            InitializeComponent();
            dashboardDesigner.CreateRibbon();
            dashboardDesigner.UseNeutralFilterMode = true;
            dashboardDesigner.LoadDashboard(path);
        }

        public DashboardState CreateDashboardState() {
            DashboardState state = new DashboardState();
            //Clears selections in the LisxBox item.
            state.Items.Add(new DashboardItemState("listBoxDashboardItem1") {
                MasterFilterValues = new List<object[]>()
            });
            //The lines below clears all values if neutral filter mode is disabled:
            //state.Items.Add(new DashboardItemState("listBoxDashboardItem1") {
            //    MasterFilterValues = null
            //});
            return state;
        }
        private void dashboardDesigner_CustomizeDashboardTitle(object sender, DevExpress.DashboardWin.CustomizeDashboardTitleEventArgs e) {
            DashboardToolbarItem resetStateItem = new DashboardToolbarItem("Reset State",
              new Action<DashboardToolbarItemClickEventArgs>((args) => {
                  dashboardDesigner.SetDashboardState(CreateDashboardState());
              }));
            resetStateItem.Caption = "Reset Dashboard State";
            e.Items.Add(resetStateItem);
        }
    }
}
