<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbnCheeseburger = New System.Windows.Forms.RadioButton()
        Me.rbnPizza = New System.Windows.Forms.RadioButton()
        Me.cmdOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Star Jedi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "i would like to order a ..."
        '
        'rbnCheeseburger
        '
        Me.rbnCheeseburger.AutoSize = True
        Me.rbnCheeseburger.Font = New System.Drawing.Font("Star Jedi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnCheeseburger.Location = New System.Drawing.Point(89, 91)
        Me.rbnCheeseburger.Name = "rbnCheeseburger"
        Me.rbnCheeseburger.Size = New System.Drawing.Size(166, 30)
        Me.rbnCheeseburger.TabIndex = 1
        Me.rbnCheeseburger.TabStop = True
        Me.rbnCheeseburger.Text = "cheeseburger"
        Me.rbnCheeseburger.UseVisualStyleBackColor = True
        '
        'rbnPizza
        '
        Me.rbnPizza.AutoSize = True
        Me.rbnPizza.Font = New System.Drawing.Font("Star Jedi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnPizza.Location = New System.Drawing.Point(89, 143)
        Me.rbnPizza.Name = "rbnPizza"
        Me.rbnPizza.Size = New System.Drawing.Size(163, 30)
        Me.rbnPizza.TabIndex = 2
        Me.rbnPizza.TabStop = True
        Me.rbnPizza.Text = "Slice of Pizza"
        Me.rbnPizza.UseVisualStyleBackColor = True
        '
        'cmdOrder
        '
        Me.cmdOrder.Font = New System.Drawing.Font("Star Jedi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrder.Location = New System.Drawing.Point(89, 192)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(158, 38)
        Me.cmdOrder.TabIndex = 3
        Me.cmdOrder.Text = "order now"
        Me.cmdOrder.UseVisualStyleBackColor = True
        '
        'frmOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 261)
        Me.Controls.Add(Me.cmdOrder)
        Me.Controls.Add(Me.rbnPizza)
        Me.Controls.Add(Me.rbnCheeseburger)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rbnCheeseburger As RadioButton
    Friend WithEvents rbnPizza As RadioButton
    Friend WithEvents cmdOrder As Button
End Class
