var GetIntegrationShipmentCompanies = function () {
    return {
        //main function to initiate the module
        init: function () {
            $('#btn-test').off('click').click(function () {
                $('#test-area').show('blind');
            });

            $('#btn-execute').off('click').click(function () {
                var getIntegrationShipmentCompanyCriteria = {
                    IntegrationId: $('#integration').val()
                };
                
                getIntegrationShipmentCompanyCriteria = JSON.stringify(getIntegrationShipmentCompanyCriteria, null, 2);

                $.ajax({
                    url: '/Service/GetIntegrationShipmentCompanies',
                    data: { 'param': getIntegrationShipmentCompanyCriteria },
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


            $('#order-status').off('click').click(function () {
                $('#status-area').show('blind');
            });

        }
    };
}();