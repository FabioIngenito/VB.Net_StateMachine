<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmState
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
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.lblVerification = New System.Windows.Forms.Label()
        Me.lblVerificationLABEL = New System.Windows.Forms.Label()
        Me.lblOperation = New System.Windows.Forms.Label()
        Me.lblOperationLABEL = New System.Windows.Forms.Label()
        Me.lblAccumulator = New System.Windows.Forms.Label()
        Me.lblAccumulatorLABEL = New System.Windows.Forms.Label()
        Me.lblGlobalCounter = New System.Windows.Forms.Label()
        Me.lblGlobalCounterLABEL = New System.Windows.Forms.Label()
        Me.tmrMultiThread = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnLaunch
        '
        Me.btnLaunch.Location = New System.Drawing.Point(16, 204)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(242, 24)
        Me.btnLaunch.TabIndex = 17
        Me.btnLaunch.Text = "Launch New Form - Lance um novo Formulário"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'lblVerification
        '
        Me.lblVerification.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerification.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVerification.Location = New System.Drawing.Point(44, 172)
        Me.lblVerification.Name = "lblVerification"
        Me.lblVerification.Size = New System.Drawing.Size(214, 18)
        Me.lblVerification.TabIndex = 16
        Me.lblVerification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVerificationLABEL
        '
        Me.lblVerificationLABEL.AutoSize = True
        Me.lblVerificationLABEL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblVerificationLABEL.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblVerificationLABEL.Location = New System.Drawing.Point(13, 154)
        Me.lblVerificationLABEL.Name = "lblVerificationLABEL"
        Me.lblVerificationLABEL.Size = New System.Drawing.Size(184, 15)
        Me.lblVerificationLABEL.TabIndex = 15
        Me.lblVerificationLABEL.Text = "TotalIncrements - Incrementação Total:"
        '
        'lblOperation
        '
        Me.lblOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOperation.Location = New System.Drawing.Point(44, 123)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(214, 18)
        Me.lblOperation.TabIndex = 14
        Me.lblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOperationLABEL
        '
        Me.lblOperationLABEL.AutoSize = True
        Me.lblOperationLABEL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblOperationLABEL.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblOperationLABEL.Location = New System.Drawing.Point(13, 105)
        Me.lblOperationLABEL.Name = "lblOperationLABEL"
        Me.lblOperationLABEL.Size = New System.Drawing.Size(107, 15)
        Me.lblOperationLABEL.TabIndex = 13
        Me.lblOperationLABEL.Text = "Operation - Operação:"
        '
        'lblAccumulator
        '
        Me.lblAccumulator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccumulator.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAccumulator.Location = New System.Drawing.Point(44, 74)
        Me.lblAccumulator.Name = "lblAccumulator"
        Me.lblAccumulator.Size = New System.Drawing.Size(214, 18)
        Me.lblAccumulator.TabIndex = 12
        Me.lblAccumulator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAccumulatorLABEL
        '
        Me.lblAccumulatorLABEL.AutoSize = True
        Me.lblAccumulatorLABEL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAccumulatorLABEL.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAccumulatorLABEL.Location = New System.Drawing.Point(13, 56)
        Me.lblAccumulatorLABEL.Name = "lblAccumulatorLABEL"
        Me.lblAccumulatorLABEL.Size = New System.Drawing.Size(135, 15)
        Me.lblAccumulatorLABEL.TabIndex = 11
        Me.lblAccumulatorLABEL.Text = "Accumulator - Acumulador:"
        '
        'lblGlobalCounter
        '
        Me.lblGlobalCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGlobalCounter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGlobalCounter.Location = New System.Drawing.Point(44, 28)
        Me.lblGlobalCounter.Name = "lblGlobalCounter"
        Me.lblGlobalCounter.Size = New System.Drawing.Size(214, 18)
        Me.lblGlobalCounter.TabIndex = 10
        Me.lblGlobalCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGlobalCounterLABEL
        '
        Me.lblGlobalCounterLABEL.AutoSize = True
        Me.lblGlobalCounterLABEL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGlobalCounterLABEL.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblGlobalCounterLABEL.Location = New System.Drawing.Point(13, 10)
        Me.lblGlobalCounterLABEL.Name = "lblGlobalCounterLABEL"
        Me.lblGlobalCounterLABEL.Size = New System.Drawing.Size(241, 15)
        Me.lblGlobalCounterLABEL.TabIndex = 9
        Me.lblGlobalCounterLABEL.Text = "GenericGlobalCounter - Contador Genérico Global:"
        '
        'tmrMultiThread
        '
        Me.tmrMultiThread.Enabled = True
        '
        'frmState
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 238)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.lblVerification)
        Me.Controls.Add(Me.lblVerificationLABEL)
        Me.Controls.Add(Me.lblOperation)
        Me.Controls.Add(Me.lblOperationLABEL)
        Me.Controls.Add(Me.lblAccumulator)
        Me.Controls.Add(Me.lblAccumulatorLABEL)
        Me.Controls.Add(Me.lblGlobalCounter)
        Me.Controls.Add(Me.lblGlobalCounterLABEL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmState"
        Me.ShowIcon = False
        Me.Text = "State - Opening multiple forms!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLaunch As Button
    Friend WithEvents lblVerification As Label
    Friend WithEvents lblVerificationLABEL As Label
    Friend WithEvents lblOperation As Label
    Friend WithEvents lblOperationLABEL As Label
    Friend WithEvents lblAccumulator As Label
    Friend WithEvents lblAccumulatorLABEL As Label
    Friend WithEvents lblGlobalCounter As Label
    Friend WithEvents lblGlobalCounterLABEL As Label
    Friend WithEvents tmrMultiThread As Timer
End Class
