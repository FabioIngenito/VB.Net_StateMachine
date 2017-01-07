Public Class clsState

#Region "Attributes"
    Public GenericGlobalCounter As Long
    Public TotalIncrements As Long
    Public ContaClone As Integer

    Private mClone As String
#End Region

#Region "Methods"

    ''' <summary>
    ''' Constructor in VB.Net - Construtor no VB.Net
    ''' </summary>
    ''' <param name="numeros">Numbers of instances - Número de Instâncias</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal numeros As Integer)
        ' Initialize numbers of instances.
        ' Inicializar um número de instâncias.
    End Sub
    Public Sub New()
        ' Initialize only one
        ' Inicializar somente uma.
    End Sub

#End Region

#Region "Properties"

    Public Property pClone() As String

        Get
            Return mClone
        End Get

        Set(ByVal value As String)
            mClone = value
        End Set

    End Property

#End Region

End Class