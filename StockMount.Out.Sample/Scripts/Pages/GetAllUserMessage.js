var GetAllUserMessage = function () {
    return {
        //main function to initiate the module
        init: function () {
            $('#btn-test').off('click').click(function () {
                $('#test-area').show('blind');
            });

            $('#btn-execute').off('click').click(function () {
                var getStoreCriteria = {
                    StoreId: $('#store').val(),
                    MessageTypeId: $('#messageType').val()
                };

                if ($('#user').val() != '') {
                    getStoreCriteria.User = $('#user').val();
                }

                if ($('#smallestIntegrationMessageId').val() != '') {
                    getStoreCriteria.BiggestIntegrationMessageId = $('#biggestIntegrationMessageId').val();
                }

                if ($('#smallestIntegrationMessageId').val() != '') {
                    getStoreCriteria.SmallestIntegrationMessageId = $('#smallestIntegrationMessageId').val();
                }

                getStoreCriteria = JSON.stringify(getStoreCriteria, null, 2);

                $.ajax({
                    url: '/Service/GetAllUserMessage',
                    data: { 'param': getStoreCriteria },
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