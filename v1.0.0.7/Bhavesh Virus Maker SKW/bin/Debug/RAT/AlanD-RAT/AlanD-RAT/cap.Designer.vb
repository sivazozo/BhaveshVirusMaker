﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.P1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.C1 = New System.Windows.Forms.ComboBox()
        Me.C2 = New System.Windows.Forms.ComboBox()
        Me.C = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P1
        '
        Me.P1.BackColor = System.Drawing.Color.Black
        Me.P1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P1.Location = New System.Drawing.Point(0, 24)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(938, 493)
        Me.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P1.TabIndex = 0
        Me.P1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(2, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Image Size:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(174, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Split:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(306, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Quality %"
        '
        'C1
        '
        Me.C1.FormattingEnabled = True
        Me.C1.Location = New System.Drawing.Point(89, 2)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(82, 21)
        Me.C1.TabIndex = 4
        '
        'C2
        '
        Me.C2.FormattingEnabled = True
        Me.C2.Location = New System.Drawing.Point(221, 1)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(82, 21)
        Me.C2.TabIndex = 5
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(382, 3)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(71, 20)
        Me.C.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(546, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 24)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Black
        Me.CheckBox1.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(458, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 19)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Show Line"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Black
        Me.CheckBox2.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Red
        Me.CheckBox2.Location = New System.Drawing.Point(632, 3)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(106, 19)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Control Mouse"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(938, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(744, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 24)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Caputer Remote Desktop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Cap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 517)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cap"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Remote Desktop"
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents P1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents C1 As System.Windows.Forms.ComboBox
    Friend WithEvents C2 As System.Windows.Forms.ComboBox
    Friend WithEvents C As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class