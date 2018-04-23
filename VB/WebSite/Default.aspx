<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v11.2, Version=11.2.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.2, Version=11.2.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>    
</head>
<body>
	<form id="form1" runat="server">
	<dx:ASPxTreeList ID="treeList" runat="server" ClientInstanceName="treeList" AutoGenerateColumns="False"
		KeyFieldName="ItemId" ParentFieldName="ParentId" KeyboardSupport="True" 
		OnDataBinding="atlSelection_DataBinding" >
		<Columns>
			<dx:TreeListCommandColumn VisibleIndex="0">
				<CustomButtons>
					<dx:TreeListCommandColumnCustomButton ID="getFile" Text="Download file">
					</dx:TreeListCommandColumnCustomButton>
				</CustomButtons>
			</dx:TreeListCommandColumn>
			<dx:TreeListTextColumn FieldName="Code" VisibleIndex="1">
			</dx:TreeListTextColumn>
			<dx:TreeListTextColumn FieldName="Name" VisibleIndex="2">
			</dx:TreeListTextColumn>
			<dx:TreeListTextColumn FieldName="Description" VisibleIndex="3">
			</dx:TreeListTextColumn>
			<dx:TreeListTextColumn FieldName="ItemType" Visible="false">
			</dx:TreeListTextColumn>
			<dx:TreeListTextColumn FieldName="Price" VisibleIndex="4">
				<PropertiesTextEdit DisplayFormatString="{0:C}">
				</PropertiesTextEdit>
			</dx:TreeListTextColumn>
		</Columns>
		<SettingsBehavior AllowFocusedNode="true" AutoExpandAllNodes="True" AllowSort="False"
			FocusNodeOnExpandButtonClick="true" />
		<SettingsEditing AllowNodeDragDrop="true" Mode="EditForm" />
		<ClientSideEvents CustomButtonClick="function(s, e) {
	window.location.href= 'LoadFile.aspx?ID=' + e.nodeKey;        
}" />
	</dx:ASPxTreeList>
	</form>
</body>
</html>