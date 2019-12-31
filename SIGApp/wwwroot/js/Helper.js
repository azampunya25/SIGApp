window.invokeControllerGET = function (controllerName, method, data, success, error, useWait) {
    if (data == null) data = {};
    $.ajax({
        dataType: 'json',
        async: true,
        contentType: 'application/json',
        type: 'GET',
        data: JSON.stringify(data),
        url: window.ServiceBaseUrl + '/' + controllerName + '/' + method,
        success: function (result) {
            if (result.Status != "E") {
                try {
                    result.Data = JSON.parse(result.Data);
                }
                catch (err) {

                }
                success(result);
            }
            else {
                alert(result.Message);
            }
        },
        error: function (jqXHR, exception) { alert(jqXHR, exception); window.endWait(); }
    });
}