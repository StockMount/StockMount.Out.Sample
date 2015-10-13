var SetOrderShipmentInformation = function () {
    return {
        //main function to initiate the module
        init: function () {
            $('#btn-test').off('click').click(function () {
                $('#test-area').show('blind');
            });

            $('#btn-execute').off('click').click(function () {
                var setShipmentCriteria = {
                    StoreId: $('#store').val(),
                    IntegrationId: $('#integration').val(),
                    OrderId: $('#orderId').val(),
                    IntegrationOrderCode: $('#integrationOrderCode').val(),
                     
                    ShipmentCompany: $('#shipmentCompany').val(),
                    ShipmentTrackingCode: $('#shipmentTrackingCode').val(),
                    ShipmentBranch: $('#shipmentBranch').val(),
                    
                    OrderDetailId: $('#orderDetailId').val(),
                    
                    SendShipmentInformation: $('#sendShipmentInformation').is(':checked')
                };
              
                if($('#campaignNumber').val() != '')
                    setShipmentCriteria.CampaignNumber = $('#campaignNumber').val();
                if ($('#shipmentCompanyId').val() != '')
                    setShipmentCriteria.ShipmentCompanyId = $('#shipmentCompanyId').val();
                     

                setShipmentCriteria = JSON.stringify(setShipmentCriteria, null, 2);

                $.ajax({
                    url: '/Service/SetOrderShipmentInformation',
                    data: { 'param': setShipmentCriteria },
                    success: function (data) {

                        var formatter = new JSONFormatter(data.Result, true);
                        $('#response-area').html(formatter.render());
                        $('#response-area').show('blind');
                    },
                    error: function (data) {


                    },
                    dataType: 'json'
                });
            });
        }
    };
}();