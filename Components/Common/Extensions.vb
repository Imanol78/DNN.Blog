﻿'
' Bring2mind - http://www.bring2mind.net
' Copyright (c) 2013
' by Bring2mind
'
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
' documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
' the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
' to permit persons to whom the Software is furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in all copies or substantial portions 
' of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
' DEALINGS IN THE SOFTWARE.
'

Imports System.Linq
Imports DotNetNuke.Modules.Blog.Common.Globals
Imports DotNetNuke.Modules.Blog.Entities.Terms
Imports System.Xml

Namespace Common
 Module Extensions

#Region " Collection Read Extensions "
  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As Hashtable, ValueName As String, ByRef Variable As Integer)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Integer)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As Hashtable, ValueName As String, ByRef Variable As Long)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Long)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As Hashtable, ValueName As String, ByRef Variable As String)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), String)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As Hashtable, ValueName As String, ByRef Variable As Boolean)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Boolean)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As Hashtable, ValueName As String, ByRef Variable As Date)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Date)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As Hashtable, ValueName As String, ByRef Variable As SummaryType)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(CType(ValueTable.Item(ValueName), Integer), SummaryType)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As Hashtable, ValueName As String, ByRef Variable As LocalizationType)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(CType(ValueTable.Item(ValueName), Integer), LocalizationType)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As Hashtable, ValueName As String, ByRef Variable As TimeSpan)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = TimeSpan.Parse(CType(ValueTable.Item(ValueName), String))
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As NameValueCollection, ValueName As String, ByRef Variable As Integer)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Integer)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As NameValueCollection, ValueName As String, ByRef Variable As Long)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Long)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As NameValueCollection, ValueName As String, ByRef Variable As String)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), String)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As NameValueCollection, ValueName As String, ByRef Variable As Boolean)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Boolean)
    Catch ex As Exception
     Select Case ValueTable.Item(ValueName).ToLower
      Case "on", "yes"
       Variable = True
      Case Else
       Variable = False
     End Select
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As NameValueCollection, ValueName As String, ByRef Variable As Date)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Date)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As NameValueCollection, ValueName As String, ByRef Variable As TimeSpan)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = TimeSpan.Parse(CType(ValueTable.Item(ValueName), String))
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ValueTable As Dictionary(Of String, String), ValueName As String, ByRef Variable As Integer)
   If ValueTable.ContainsKey(ValueName) Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Integer)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ValueTable As Dictionary(Of String, String), ValueName As String, ByRef Variable As String)
   If ValueTable.ContainsKey(ValueName) Then
    Try
     Variable = CType(ValueTable.Item(ValueName), String)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ValueTable As Dictionary(Of String, String), ValueName As String, ByRef Variable As Boolean)
   If ValueTable.ContainsKey(ValueName) Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Boolean)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ValueTable As Dictionary(Of String, String), ValueName As String, ByRef Variable As Date)
   If ValueTable.ContainsKey(ValueName) Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Date)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ValueTable As Dictionary(Of String, String), ValueName As String, ByRef Variable As TimeSpan)
   If ValueTable.ContainsKey(ValueName) Then
    Try
     Variable = TimeSpan.Parse(CType(ValueTable.Item(ValueName), String))
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As StateBag, ValueName As String, ByRef Variable As Integer)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Integer)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As StateBag, ValueName As String, ByRef Variable As Long)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Long)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As StateBag, ValueName As String, ByRef Variable As String)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), String)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As StateBag, ValueName As String, ByRef Variable As Boolean)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Boolean)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As StateBag, ValueName As String, ByRef Variable As Date)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.Item(ValueName), Date)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As StateBag, ValueName As String, ByRef Variable As TimeSpan)
   If Not ValueTable.Item(ValueName) Is Nothing Then
    Try
     Variable = TimeSpan.Parse(CType(ValueTable.Item(ValueName), String))
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As XmlNode, ValueName As String, ByRef Variable As Integer)
   If Not ValueTable.SelectSingleNode(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.SelectSingleNode(ValueName).InnerText, Integer)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As XmlNode, ValueName As String, ByRef Variable As Long)
   If Not ValueTable.SelectSingleNode(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.SelectSingleNode(ValueName).InnerText, Long)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As XmlNode, ValueName As String, ByRef Variable As String)
   If Not ValueTable.SelectSingleNode(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.SelectSingleNode(ValueName).InnerText, String)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As XmlNode, ValueName As String, ByRef Variable As Boolean)
   If Not ValueTable.SelectSingleNode(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.SelectSingleNode(ValueName).InnerText, Boolean)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As XmlNode, ValueName As String, ByRef Variable As Date)
   If Not ValueTable.SelectSingleNode(ValueName) Is Nothing Then
    Try
     Variable = CType(ValueTable.SelectSingleNode(ValueName).InnerText, Date)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As XmlNode, ValueName As String, ByRef Variable As SummaryType)
   If Not ValueTable.SelectSingleNode(ValueName) Is Nothing Then
    Try
     Variable = CType(CType(ValueTable.SelectSingleNode(ValueName).InnerText, Integer), SummaryType)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As XmlNode, ValueName As String, ByRef Variable As LocalizationType)
   If Not ValueTable.SelectSingleNode(ValueName) Is Nothing Then
    Try
     Variable = CType(CType(ValueTable.SelectSingleNode(ValueName).InnerText, Integer), LocalizationType)
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As XmlNode, ValueName As String, ByRef Variable As TimeSpan)
   If Not ValueTable.SelectSingleNode(ValueName) Is Nothing Then
    Try
     Variable = TimeSpan.Parse(CType(ValueTable.SelectSingleNode(ValueName).InnerText, String))
    Catch ex As Exception
    End Try
   End If
  End Sub

  <System.Runtime.CompilerServices.Extension()>
  Public Sub ReadValue(ByRef ValueTable As XmlNode, ValueName As String, ByRef Variable As LocalizedText)
   If Not ValueTable.SelectSingleNode(ValueName) Is Nothing Then
    If Not ValueTable.SelectSingleNode(ValueName).SelectSingleNode("MLText") Is Nothing Then
     If Variable Is Nothing Then Variable = New LocalizedText
     For Each t As XmlNode In ValueTable.SelectSingleNode(ValueName).SelectSingleNode("MLText").SelectNodes("Text")
      Variable.Add(t.Attributes("Locale").InnerText, t.InnerText)
     Next
    End If
   End If
  End Sub
#End Region

#Region " Conversion Extensions "
  <System.Runtime.CompilerServices.Extension()>
  Public Function ToInt(var As Boolean) As Integer
   If var Then
    Return 1
   Else
    Return 0
   End If
  End Function

  <System.Runtime.CompilerServices.Extension()>
  Public Function ToYesNo(var As Boolean) As String
   If var Then
    Return "Yes"
   Else
    Return "No"
   End If
  End Function

  <System.Runtime.CompilerServices.Extension()>
  Public Function ToInt(var As String) As Integer
   If IsNumeric(var) Then
    Return Integer.Parse(var)
   Else
    Return -1
   End If
  End Function

  <System.Runtime.CompilerServices.Extension()>
  Public Function ToBool(var As Integer) As Boolean
   Return CBool(var > 0)
  End Function

  <System.Runtime.CompilerServices.Extension()>
  Public Function ToStringArray(terms As List(Of TermInfo)) As String()
   Return terms.Select(Function(x)
                        Return x.Name
                       End Function).ToArray
  End Function

  <System.Runtime.CompilerServices.Extension()>
  Public Function ToTermIDString(terms As List(Of TermInfo)) As String
   Return ToTermIDString(terms, ";")
  End Function

  <System.Runtime.CompilerServices.Extension()>
  Public Function ToTermIDString(terms As List(Of TermInfo), separator As String) As String
   Dim res As New List(Of String)
   For Each t As TermInfo In terms
    res.Add(t.TermId.ToString)
   Next
   Return String.Join(separator, res.ToArray)
  End Function

  <System.Runtime.CompilerServices.Extension()>
  Public Function ToStringOrZero(value As Integer?) As String
   If value Is Nothing Then
    Return "0"
   Else
    Return value.ToString
   End If
  End Function
#End Region

#Region " Other "
  <System.Runtime.CompilerServices.Extension()>
  Public Function FindControlByID(Control As System.Web.UI.Control, id As String) As Control
   Dim found As Control = Nothing
   If Control IsNot Nothing Then
    If Control.ID = id Then
     found = Control
    Else
     found = FindControlByID(Control.Controls, id)
    End If
   End If
   Return found
  End Function

  <System.Runtime.CompilerServices.Extension()>
  Public Function FindControlByID(Controls As System.Web.UI.ControlCollection, id As String) As Control
   Dim found As Control = Nothing
   If Controls IsNot Nothing AndAlso Controls.Count > 0 Then
    For i As Integer = 0 To Controls.Count - 1
     If Controls(i).ID = id Then
      found = Controls(i)
     Else
      found = FindControlByID(Controls(i).Controls, id)
     End If
     If found IsNot Nothing Then Exit For
    Next
   End If
   Return found
  End Function

  <System.Runtime.CompilerServices.Extension()>
  Public Function OutputHtml(encodedHtml As String, strFormat As String) As String
   Select Case strFormat.ToLower
    Case ""
     Return HttpUtility.HtmlDecode(encodedHtml)
    Case "js"
     Return HttpUtility.HtmlDecode(encodedHtml).Replace("""", "\""").Replace("'", "\'").Replace(vbCrLf, "\r\n")
    Case Else
     If IsNumeric(strFormat) Then
      Return RemoveHtmlTags(HttpUtility.HtmlDecode(encodedHtml)).Substring(0, Integer.Parse(strFormat))
     Else
      Return HttpUtility.HtmlDecode(encodedHtml)
     End If
   End Select
  End Function

  <System.Runtime.CompilerServices.Extension()>
  Public Sub WriteAttachmentToXml(attachment As BlogML.Xml.BlogMLAttachment, writer As System.Xml.XmlWriter)
   writer.WriteStartElement("File")
   writer.WriteElementString("Path", attachment.Path)
   writer.WriteStartElement("Data")
   writer.WriteBase64(attachment.Data, 0, attachment.Data.Length - 1)
   writer.WriteEndElement() ' Data
   writer.WriteEndElement() ' File
  End Sub
#End Region

 End Module
End Namespace
