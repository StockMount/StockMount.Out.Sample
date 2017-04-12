var GetCurrencies = function () {
    return {
        //main function to initiate the module
        init: function () {
            $('#btn-test').off('click').click(function () {
                $('#test-area').show('blind');
            });

            $('#btn-execute').off('click').click(function () {
                


                $.ajax({
                    url: '/Service/GetCurrencies',
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