Imports System.Xml

Public Class Filesystem
    Public Sub SaveToCSV(ByVal activityCollection As ActivityCollection(Of Activity), ByVal path As String)
        Dim csv As String = ""

        Dim email As Boolean = False

        Dim em As String = InputBox("If you're exporting to Toggl Track, enter the email you want to attach these tasks to.", "CSV Export")

        email = Not (em = "")

        If email Then
            csv &= "Email,"
        End If
        csv &= "Project,Description,Start date,Start time,Duration" & Environment.NewLine
        For Each a As Activity In activityCollection
            For Each s As Session In a.Events
                If email Then
                    csv &= em & ","
                End If
                csv &= a.Name & "," & s.Comment.Replace(",", " ").Replace("""", "").Replace(Environment.NewLine, "  ") & "," & s.StartTime.ToString("yyyy-MM-dd") & "," & s.StartTime.ToString("HH\:mm\:ss") & "," & s.TimeSpan.ToString("hh\:mm\:ss") & Environment.NewLine
            Next
        Next

        My.Computer.FileSystem.WriteAllText(path, csv, False)
    End Sub

    Public Sub SaveToXML(ByVal activityCollection As ActivityCollection(Of Activity), ByVal path As String)

        Dim writer As New XmlTextWriter(path, System.Text.Encoding.UTF8)

        writer.Formatting = Formatting.Indented
        writer.Indentation = 2

        writer.WriteStartDocument()

        writer.WriteStartElement("Projects")

        For Each act As Activity In activityCollection
            writer.WriteStartElement("Activity")
            writer.WriteAttributeString("Name", act.Name)
            If Not act.Category = "" Then
                writer.WriteAttributeString("Category", act.Category)
            End If
            'If Not a.Attachment = "" Then
            '    writer.WriteAttributeString("Attachment", a.Attachment)
            'End If
            For Each s As Session In act.Events
                writer.WriteStartElement("Session")
                writer.WriteStartElement("StartTime")
                writer.WriteString(s.StartTime.ToString("o"))
                writer.WriteEndElement()
                writer.WriteStartElement("EndTime")
                writer.WriteString(s.EndTime.ToString("o"))
                writer.WriteEndElement()
                writer.WriteStartElement("Rating")
                writer.WriteString(CStr(s.Rating))
                writer.WriteEndElement()
                writer.WriteStartElement("Comment")
                writer.WriteString(s.Comment)
                writer.WriteEndElement()
                writer.WriteEndElement()
            Next
            For Each a As Attachment In act.Attachments
                writer.WriteStartElement("Attachment")
                writer.WriteStartElement("Label")
                writer.WriteString(a.Label)
                writer.WriteEndElement()
                writer.WriteStartElement("Path")
                writer.WriteString(a.Path)
                writer.WriteEndElement()
                writer.WriteStartElement("ImageIndex")
                writer.WriteString(CStr(a.ImageIndex))
                writer.WriteEndElement()
                writer.WriteStartElement("Index")
                writer.WriteString(CStr(a.Index))
                writer.WriteEndElement()
                writer.WriteEndElement()
            Next
            writer.WriteEndElement()
        Next
        writer.WriteEndElement()
        writer.WriteEndDocument()

        writer.Close()
    End Sub

    Public Function LoadFromXML(ByVal path As String) As ActivityCollection(Of Activity)
        Dim activities As New ActivityCollection(Of Activity)

        Dim reader As New XmlTextReader(path)

        Dim currentActivity As Activity
        Dim currentSession As Session
        Dim currentAttachment As Attachment
        Try

            While reader.Read()
                If reader.IsStartElement() Then

                    If reader.Name = "Activity" Then
                        currentActivity = New Activity
                        currentActivity.Name = "MissingNo."
                        activities.Add(currentActivity)
                        If Not reader.GetAttribute("Name") Is Nothing Then
                            currentActivity.Name = reader.GetAttribute("Name")
                        End If
                        If Not reader.GetAttribute("Category") Is Nothing Then
                            currentActivity.Category = reader.GetAttribute("Category")
                        End If
                        'If Not reader.GetAttribute("Attachment") Is Nothing Then
                        '    currentActivity.Attachment = reader.GetAttribute("Name")
                        'End If
                    End If
                    If Not currentActivity Is Nothing Then
                        If reader.Name = "Session" Then
                            currentSession = New Session(Date.MinValue, Date.MinValue)
                            currentSession.Parent = currentActivity.Events
                            currentSession.Comment = ""
                            currentSession.Rating = 0
                            currentActivity.Events.Add(currentSession)
                        End If

                        If reader.Name = "Attachment" Then
                            currentAttachment = New Attachment
                            currentAttachment.Parent = currentActivity.Attachments
                            currentAttachment.Index = 0
                            currentAttachment.Label = ""
                            currentAttachment.Path = ""
                            currentAttachment.ImageIndex = 0
                            currentActivity.Attachments.Add(currentAttachment)
                        End If
                    End If

                    If Not currentSession Is Nothing Then
                        If reader.Name = "Rating" Then
                            currentSession.Rating = reader.ReadElementContentAsInt
                        End If
                        If reader.Name = "StartTime" Then
                            currentSession.StartTime = reader.ReadElementContentAsDateTime
                        End If
                        If reader.Name = "EndTime" Then
                            currentSession.EndTime = reader.ReadElementContentAsDateTime
                        End If
                        If reader.Name = "Comment" Then
                            currentSession.Comment = reader.ReadElementContentAsString
                        End If
                    End If

                    If Not currentAttachment Is Nothing Then
                        If reader.Name = "Label" Then
                            currentAttachment.Label = reader.ReadElementContentAsString
                        End If
                        If reader.Name = "Index" Then
                            currentAttachment.Index = reader.ReadElementContentAsInt
                        End If
                        If reader.Name = "Path" Then
                            currentAttachment.Path = reader.ReadElementContentAsString
                        End If
                        If reader.Name = "ImageIndex" Then
                            currentAttachment.ImageIndex = reader.ReadElementContentAsInt
                        End If
                    End If

                End If

            End While

        Catch ex As XmlException
            reader.Close()

            MsgBox("There was an issue reading the XML file. This could be a mismatched start and end tag." & vbNewLine & "We'll make a quick backup of the file but please check it carefully to fix any issues if you want to load it.")
            My.Computer.FileSystem.CopyFile("hours_data.xml", "hours_data_backup.xml")
            Throw New XmlException
        End Try
        reader.Close()

        Return activities
    End Function

End Class
