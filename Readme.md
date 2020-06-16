*Files to look at*:
* [DesignerForm1.cs](./CS/WinDesignerDashboardState/DesignerForm1.cs) (VB: [DesignerForm1.vb](./VB/WinDesignerDashboardState/DesignerForm1.vb))

# How to Clear Filter Values in a Dashboard State 

This example shows how to clear/select all filter values in a Dashboard state.

![](/image.png)

When the application starts, the **DashboardDesigner** loads a dashboard and a [DashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardState) object.

When the [neutral filter mode](https://docs.devexpress.com/Dashboard/400262/common-features/interactivity/neutral-filter-mode?p=netframework) is enabled (**UseNeutralFilterMode == true**), pass an empty **MasterFilterValues** object of a dashboard item to the entire dashboard state to clear filters (unselect all values).

When the [neutral filter mode](https://docs.devexpress.com/Dashboard/400262/common-features/interactivity/neutral-filter-mode?p=netframework) is disabled (**UseNeutralFilterMode == false**), for the **multiple** master filter mode there is a difference between _null_ and _empty_ master filter values:

|MasterFilterValues values|Behavior|
|----|----|
| MasterFilterValues = null | The control filters data by all values (all values are selected). |
| MasterFilterValues = [] | The control excludes all filter (no data is selected). |

To select all values, assign _null_ to the **MasterFilterValues** object of a dashboard item and pass it to the entire dashboard state.

The [DashboardDesigner.SetDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.SetDashboardState(DevExpress.DashboardCommon.DashboardState)?p=netframework) method applies the created dashboard state at runtime. 

You can click the **Reset Dashboard State** button to apply the dashboard state at runtime.

## See Also

- [Manage Dashboard State](https://docs.devexpress.com/Dashboard/400730)
- [How to Save and Restore the Dashboard State](https://github.com/DevExpress-Examples/winforms-dashboard-save-restore-dashboard-state)
- [How to Set the Initial Dashboard State in the WinForms Viewer](https://github.com/DevExpress-Examples/winforms-viewer-save-and-apply-dashboard-state)
- [How to Set the Initial Dashboard State in the WPF Dashboard](https://github.com/DevExpress-Examples/wpf-dashboard-how-to-set-initial-dashboard-state)
