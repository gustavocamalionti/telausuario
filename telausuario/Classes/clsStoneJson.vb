Public Class clsStoneJson
    Public Class clsRegistrarEstabelecimento
        Public Property is_establishment_to_production As Boolean
        Public Property legal_name As String
        Public Property business_name As String
        Public Property document_number As String
        Public Property stone_code As String
        Public Property partner_stone_id As Integer 'int32

    End Class

    Public Class clsConfigurarPos

        '"establishment_id": "7e3beb4c-bcec-44d8-9c6d-da77b16123453",
        '"use_without_pos_config": 0,
        '"activate_linked_pos_config": 1, //Configuração exclusiva definida pelo envio desse campo como true
        '"activate_unlinked_and_linked_pos_config": false,
        '"activate_single_information_automatic_select": 0,
        '"activate_dispose_transaction_any_pos": false,
        '"lock_app": 0,
        '"view_error_request": true,
        '"display_view_cancel_pre_transaction": false,
        '"instruction_activation_time": 1500,
        Public Property establishment_id As String
        Public Property use_without_pos_config As Integer
        Public Property activate_linked_pos_config As Integer
        Public Property activate_unlinked_and_linked_pos_config As Boolean
        Public Property activate_single_information_automatic_select As Integer
        Public Property activate_dispose_transaction_any_pos As Boolean
        Public Property lock_app As Integer
        Public Property view_error_request As Boolean
        Public Property display_view_cancel_pre_transaction As Boolean
        Public Property instruction_activation_time As Integer

    End Class

    Public Class clsAtivarPos
        Public Property cashier_number As String
        Public Property pos_link_label As String
        Public Property pos_serial_number_to_link As String


    End Class

    Public Class clsCriarPreTransacoes

        Public Property payment As New clsPayment
        Public Property pos_reference_id As String
        Public Property establishment_id As String
        Public Property amount As Integer
        Public Property information_title As String
    End Class

    Public Class clsConsultaPreTransacoes
        Public Property establishment_id As String
        Public Property data As String
        'Public Property installment As String
        'Public Property installment_type As Integer
    End Class

    Public Class clsListarTransacoes
        Public Property establishment_id As String
        Public Property period_type As String
        Public Property period As String
        Public Property transaction_status As Integer
 
    End Class

    Public Class clsStoneWebhookPreTransacao
        Public Property establishment_id As String
        Public Property postback_url As String
    End Class

    Public Class clsPayment
        Public Property type As Integer
        'Public Property installment As String
        'Public Property installment_type As Integer
    End Class

    Public Class clsStoneConsultarExtrato
        Public Property provider_id As String
        Public Property initial_date As String
        Public Property till_date As String
        Public Property is_establishment As Boolean
    End Class

    Public Class clsStoneReativarEstabelecimento
        Public Property establishment_id As String
        Public Property stone_code As String


    End Class
End Class
