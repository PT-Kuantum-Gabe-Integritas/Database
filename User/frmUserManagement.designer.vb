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
        Me.bnt_clearall = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.tb_input = New System.Windows.Forms.TextBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lb_delete = New System.Windows.Forms.Label()
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.cb_columname = New System.Windows.Forms.ComboBox()
        Me.lb_val = New System.Windows.Forms.Label()
        Me.tb_val = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(441, 48)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(84, 23)
        Me.btn_delete.TabIndex = 38
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(547, 48)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(84, 23)
        Me.btn_refresh.TabIndex = 39
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'bnt_clearall
        '
        Me.bnt_clearall.Location = New System.Drawing.Point(547, 106)
        Me.bnt_clearall.Name = "bnt_clearall"
        Me.bnt_clearall.Size = New System.Drawing.Size(84, 23)
        Me.bnt_clearall.TabIndex = 28
        Me.bnt_clearall.Text = "Clear All"
        Me.bnt_clearall.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(441, 106)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(84, 23)
        Me.btn_update.TabIndex = 42
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(441, 77)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(84, 23)
        Me.btn_open.TabIndex = 29
        Me.btn_open.Text = "Open"
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'tb_input
        '
        Me.tb_input.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_input.Location = New System.Drawing.Point(4, 156)
        Me.tb_input.Name = "tb_input"
        Me.tb_input.Size = New System.Drawing.Size(624, 20)
        Me.tb_input.TabIndex = 44
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(547, 77)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(84, 23)
        Me.btn_close.TabIndex = 30
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'lb_delete
        '
        Me.lb_delete.AutoSize = True
        Me.lb_delete.Location = New System.Drawing.Point(219, 29)
        Me.lb_delete.Name = "lb_delete"
        Me.lb_delete.Size = New System.Drawing.Size(36, 13)
        Me.lb_delete.TabIndex = 49
        Me.lb_delete.Text = "param"
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.Location = New System.Drawing.Point(0, 188)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTable.Size = New System.Drawing.Size(627, 203)
        Me.DataGridViewTable.TabIndex = 45
        '
        'cb_columname
        '
        Me.cb_columname.FormattingEnabled = True
        Me.cb_columname.Location = New System.Drawing.Point(261, 29)
        Me.cb_columname.Name = "cb_columname"
        Me.cb_columname.Size = New System.Drawing.Size(100, 21)
        Me.cb_columname.TabIndex = 51
        '
        'lb_val
        '
        Me.lb_val.AutoSize = True
        Me.lb_val.Location = New System.Drawing.Point(219, 56)
        Me.lb_val.Name = "lb_val"
        Me.lb_val.Size = New System.Drawing.Size(22, 13)
        Me.lb_val.TabIndex = 52
        Me.lb_val.Text = "Val"
        '
        'tb_val
        '
        Me.tb_val.Location = New System.Drawing.Point(261, 56)
        Me.tb_val.Name = "tb_val"
        Me.tb_val.Size = New System.Drawing.Size(100, 20)
        Me.tb_val.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_val)
        Me.GroupBox1.Controls.Add(Me.lb_val)
        Me.GroupBox1.Controls.Add(Me.cb_columname)
        Me.GroupBox1.Controls.Add(Me.DataGridViewTable)
        Me.GroupBox1.Controls.Add(Me.lb_delete)
        Me.GroupBox1.Controls.Add(Me.btn_close)
        Me.GroupBox1.Controls.Add(Me.tb_input)
        Me.GroupBox1.Controls.Add(Me.btn_open)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.bnt_clearall)
        Me.GroupBox1.Controls.Add(Me.btn_refresh)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 391)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test Box"
        '
        'frmUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 415)
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
    Friend WithEvents bnt_clearall As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_open As Button
    Friend WithEvents tb_input As TextBox
    Friend WithEvents btn_close As Button
    Friend WithEvents lb_delete As Label
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents cb_columname As ComboBox
    Friend WithEvents lb_val As Label
    Friend WithEvents tb_val As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
