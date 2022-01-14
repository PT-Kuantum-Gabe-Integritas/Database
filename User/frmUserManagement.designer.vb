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
        Me.btn_delete.Location = New System.Drawing.Point(108, 61)
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
        Me.btn_refresh.Location = New System.Drawing.Point(9, 19)
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
        Me.btn_update.Location = New System.Drawing.Point(9, 61)
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
        Me.btn_close.Location = New System.Drawing.Point(314, 19)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(84, 23)
        Me.btn_close.TabIndex = 30
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.Location = New System.Drawing.Point(6, 101)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTable.Size = New System.Drawing.Size(402, 203)
        Me.DataGridViewTable.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewTable)
        Me.GroupBox1.Controls.Add(Me.btn_close)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.btn_refresh)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 317)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'btn_add
        '
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_add.Location = New System.Drawing.Point(108, 19)
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
        Me.ClientSize = New System.Drawing.Size(439, 335)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUserManagement"
        Me.Text = "TestForm"
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_add As Button
End Class
