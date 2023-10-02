<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnClickHere = New Button()
        txtName = New TextBox()
        txtSurname = New TextBox()
        lbName = New Label()
        lbSurname = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btnClickHere
        ' 
        btnClickHere.BackColor = SystemColors.HotTrack
        btnClickHere.Location = New Point(385, 383)
        btnClickHere.Name = "btnClickHere"
        btnClickHere.Size = New Size(94, 45)
        btnClickHere.TabIndex = 0
        btnClickHere.Text = "Click Here"
        btnClickHere.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(366, 102)
        txtName.Name = "txtName"
        txtName.Size = New Size(178, 27)
        txtName.TabIndex = 1
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(366, 156)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(178, 27)
        txtSurname.TabIndex = 1
        ' 
        ' lbName
        ' 
        lbName.AutoSize = True
        lbName.ForeColor = SystemColors.ActiveCaptionText
        lbName.Location = New Point(224, 112)
        lbName.Name = "lbName"
        lbName.Size = New Size(49, 20)
        lbName.TabIndex = 2
        lbName.Text = "Name"
        ' 
        ' lbSurname
        ' 
        lbSurname.AutoSize = True
        lbSurname.Location = New Point(224, 163)
        lbSurname.Name = "lbSurname"
        lbSurname.Size = New Size(67, 20)
        lbSurname.TabIndex = 2
        lbSurname.Text = "Surname"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(385, 280)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 24)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Sigh Me Up"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(385, 310)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(95, 24)
        CheckBox2.TabIndex = 3
        CheckBox2.Text = "Subscribe"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(648, 112)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(63, 24)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(648, 156)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(78, 24)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(648, 196)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(67, 24)
        RadioButton3.TabIndex = 4
        RadioButton3.TabStop = True
        RadioButton3.Text = "Other"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Students", "Teachers", "Professionals", "Managers"})
        ComboBox1.Location = New Point(366, 211)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(178, 28)
        ComboBox1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(224, 219)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 20)
        Label1.TabIndex = 6
        Label1.Text = "Profession"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("MV Boli", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(240, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(576, 47)
        Label2.TabIndex = 7
        Label2.Text = "Sign Up For The Mindworx LMS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(879, 483)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(lbSurname)
        Controls.Add(lbName)
        Controls.Add(txtSurname)
        Controls.Add(txtName)
        Controls.Add(btnClickHere)
        Name = "Form1"
        Text = "Intro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClickHere As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lbName As Label
    Friend WithEvents lbSurname As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
