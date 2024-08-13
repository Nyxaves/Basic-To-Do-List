<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.clbToDoList = New System.Windows.Forms.CheckedListBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnDeleteAll = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'clbToDoList
        '
        Me.clbToDoList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbToDoList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbToDoList.FormattingEnabled = True
        Me.clbToDoList.Location = New System.Drawing.Point(23, 93)
        Me.clbToDoList.Name = "clbToDoList"
        Me.clbToDoList.Size = New System.Drawing.Size(292, 330)
        Me.clbToDoList.TabIndex = 0
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(23, 57)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(225, 30)
        Me.txtInput.TabIndex = 1
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.SkyBlue
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEnter.Location = New System.Drawing.Point(254, 57)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(61, 30)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "↩"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnSort
        '
        Me.btnSort.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSort.Location = New System.Drawing.Point(240, 19)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 23)
        Me.btnSort.TabIndex = 3
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = False
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnDeleteAll.Location = New System.Drawing.Point(146, 19)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(88, 23)
        Me.btnDeleteAll.TabIndex = 4
        Me.btnDeleteAll.Text = "Delete All"
        Me.btnDeleteAll.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(23, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Del. checked"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 448)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.clbToDoList)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clbToDoList As CheckedListBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnSort As Button
    Friend WithEvents btnDeleteAll As Button
    Friend WithEvents btnDelete As Button
End Class
