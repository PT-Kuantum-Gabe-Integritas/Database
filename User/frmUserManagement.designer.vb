<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagement
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
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_confirm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_info = New System.Windows.Forms.Label()
        Me.cb_user = New System.Windows.Forms.ComboBox()
        Me.tb_input = New System.Windows.Forms.TextBox()
        Me.lb_user = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_delete.Location = New System.Drawing.Point(557, 285)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(84, 23)
        Me.btn_delete.TabIndex = 38
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_refresh.Location = New System.Drawing.Point(557, 321)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(84, 23)
        Me.btn_refresh.TabIndex = 39
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_update.Location = New System.Drawing.Point(447, 321)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(84, 23)
        Me.btn_update.TabIndex = 42
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Red
        Me.btn_close.Location = New System.Drawing.Point(562, 11)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(84, 23)
        Me.btn_close.TabIndex = 30
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.Location = New System.Drawing.Point(9, 19)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTable.Size = New System.Drawing.Size(432, 333)
        Me.DataGridViewTable.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_confirm)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lb_info)
        Me.GroupBox1.Controls.Add(Me.cb_user)
        Me.GroupBox1.Controls.Add(Me.tb_input)
        Me.GroupBox1.Controls.Add(Me.lb_user)
        Me.GroupBox1.Controls.Add(Me.DataGridViewTable)
        Me.GroupBox1.Controls.Add(Me.btn_close)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.btn_refresh)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 360)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'tb_confirm
        '
        Me.tb_confirm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_confirm.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_confirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.tb_confirm.Location = New System.Drawing.Point(447, 236)
        Me.tb_confirm.Name = "tb_confirm"
        Me.tb_confirm.Size = New System.Drawing.Size(194, 25)
        Me.tb_confirm.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(447, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 28)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Confirm New Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_info
        '
        Me.lb_info.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lb_info.Location = New System.Drawing.Point(447, 37)
        Me.lb_info.Name = "lb_info"
        Me.lb_info.Size = New System.Drawing.Size(194, 78)
        Me.lb_info.TabIndex = 47
        Me.lb_info.Text = "Select Role"
        Me.lb_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_user
        '
        Me.cb_user.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_user.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.cb_user.FormattingEnabled = True
        Me.cb_user.Items.AddRange(New Object() {"Operator", "Engineer", "Administrator"})
        Me.cb_user.Location = New System.Drawing.Point(447, 118)
        Me.cb_user.Name = "cb_user"
        Me.cb_user.Size = New System.Drawing.Size(194, 25)
        Me.cb_user.TabIndex = 46
        '
        'tb_input
        '
        Me.tb_input.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_input.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.tb_input.Location = New System.Drawing.Point(447, 177)
        Me.tb_input.Name = "tb_input"
        Me.tb_input.Size = New System.Drawing.Size(194, 25)
        Me.tb_input.TabIndex = 48
        '
        'lb_user
        '
        Me.lb_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_user.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lb_user.Location = New System.Drawing.Point(447, 146)
        Me.lb_user.Name = "lb_user"
        Me.lb_user.Size = New System.Drawing.Size(194, 28)
        Me.lb_user.TabIndex = 49
        Me.lb_user.Text = "Insert New Password"
        Me.lb_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_add
        '
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_add.Location = New System.Drawing.Point(447, 285)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(84, 23)
        Me.btn_add.TabIndex = 29
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'frmUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(679, 381)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUserManagement"
        Me.Text = "TestForm"
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_add As Button
    Friend WithEvents tb_confirm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_info As Label
    Friend WithEvents cb_user As ComboBox
    Friend WithEvents tb_input As TextBox
    Friend WithEvents lb_user As Label
End Class
