﻿var GetProductSources = function () { 
    return {
        //main function to initiate the module
        init: function () {
            $('#btn-test').off('click').click(function () {
                $('#test-area').show('blind');
            });

            $('#btn-execute').off('click').click(function () {
                var getProductCriteria = {
                };

                getProductCriteria = JSON.stringify(getProductCriteria, null, 2);

                $.ajax({
                    url: '/Service/GetProductSources',
                    data: { 'param': getProductCriteria },
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