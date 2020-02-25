﻿Imports System
Imports System.Windows.Media
Imports DevExpress.Mvvm

Namespace DXSample.ViewModels
	Public Class TimeRegionViewModel
		Inherits ViewModelBase

		Public Property Id() As Integer
			Get
				Return GetValue(Of Integer)()
			End Get
			Set(ByVal value As Integer)
				SetValue(value)
			End Set
		End Property
		Public Property StartTime() As DateTime
			Get
				Return GetValue(Of DateTime)()
			End Get
			Set(ByVal value As DateTime)
				SetValue(value)
			End Set
		End Property
		Public Property EndTime() As DateTime
			Get
				Return GetValue(Of DateTime)()
			End Get
			Set(ByVal value As DateTime)
				SetValue(value)
			End Set
		End Property
		Public Property Brush() As SolidColorBrush
			Get
				Return GetValue(Of SolidColorBrush)()
			End Get
			Set(ByVal value As SolidColorBrush)
				SetValue(value)
			End Set
		End Property
		Public Property ResourceId() As Integer
			Get
				Return GetValue(Of Integer)()
			End Get
			Set(ByVal value As Integer)
				SetValue(value)
			End Set
		End Property
	End Class
End Namespace