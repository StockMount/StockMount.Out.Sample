var DoLogin = function () { 
    return {
        //main function to initiate the module
        init: function () {
            $('#btn-test').off('click').click(function() {
                $('#test-area').show('blind');
            });

            $('#btn-execute').off('click').click(function () {
                var loginUser = {
                    UserName: $('#userName').val(),
                    Password: $('#password').val()
                };

                loginUser = JSON.stringify(loginUser, null, 2);

                $.ajax({
                    url: '/Service/DoLogin',
                    data: { 'param': loginUser },
                    success: function (data) {
                        



                        $('#response-area').html('</br>');
                         
                            var formatter = new JSONFormatter(data.Result,true);  
                            $('#response-area').html(formatter.render());
                             
                            //$('#response-area').append(
                            //$('<blockquote>').append(
                            //    $('<p>', { html: '<strong>Result :</strong> ' + data.Result.Result }),
                            //    $('<p>', { html: '<strong>ErrorCode :</strong> ' + data.Result.ErrorCode })
                            //    ));
                      
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