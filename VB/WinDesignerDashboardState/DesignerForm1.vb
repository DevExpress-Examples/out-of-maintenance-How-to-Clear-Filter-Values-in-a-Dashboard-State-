Imports Microsoft.VisualBasic
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports System
Imports System.Collections.Generic
Imports System.Xml.Linq

Namespace WinDesignerDashboardState
	Partial Public Class DesignerForm1
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm
		Private Const path As String = "..\..\Dashboards\dashboardWithSavedState.xml"
		Public Sub New()
			InitializeComponent()
			dashboardDesigner.CreateRibbon()
			dashboardDesigner.UseNeutralFilterMode = True
			dashboardDesigner.LoadDashboard(path)
		End Sub

		Public Function CreateDashboardState() As DashboardState
			Dim state As New DashboardState()
			'Clears selections in the LisxBox item.
			state.Items.Add(New DashboardItemState("listBoxDashboardItem1") With {.MasterFilterValues = New List(Of Object())()})
			'The lines below clears all values if neutral filter mode is disabled:
			'state.Items.Add(new DashboardItemState("listBoxDashboardItem1") {
			'    MasterFilterValues = null
			'});
			Return state
		End Function
		Private Sub dashboardDesigner_CustomizeDashboardTitle(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.CustomizeDashboardTitleEventArgs) Handles dashboardDesigner.CustomizeDashboardTitle
			Dim resetStateItem As New DashboardToolbarItem("Reset State", New Action(Of DashboardToolbarItemClickEventArgs)(Function(args) AnonymousMethod1(args)))
			resetStateItem.Caption = "Reset Dashboard State"
			e.Items.Add(resetStateItem)
		End Sub
		
		Private Function AnonymousMethod1(ByVal args As Object) As Boolean
			dashboardDesigner.SetDashboardState(CreateDashboardState())
			Return True
		End Function
	End Class
End Namespace
