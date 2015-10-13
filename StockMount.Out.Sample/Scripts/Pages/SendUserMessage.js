var SendUserMessage = function () {
    return {
        //main function to initiate the module
        init: function () {
            $('#btn-test').off('click').click(function () {
                $('#test-area').show('blind');
            });

            $('#btn-execute').off('click').click(function () {
                var setMessageCriteria = {
                    StoreId: $('#store').val(),
                    IntegrationId: $('#integration').val(),
                    UserMessageId: $('#messageId').val(),
                    UserMessageCode: $('#messageCode').val(),
                    SetMessageRead: $('#messageRead').is(':checked'),
                    Message: $('#messageBody').val(),
                    To: $('#messageTo').val(),
                    From: $('#messageFrom').val(),
                    Subject: $('#messageSubject').val(),
                };

                setMessageCriteria = JSON.stringify(setMessageCriteria, null, 2);

                $.ajax({
                    url: '/Service/SendUserMessage',
                    data: { 'param': setMessageCriteria },
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