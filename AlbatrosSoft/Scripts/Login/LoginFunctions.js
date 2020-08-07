function CreateAlert() {
    alert("Estimado Cliente: Por favor contáctese con el personal de soporte a través de la línea 6962791 Ext. 107.");
}

function CreateAlertjQuery() {
    $("#dialog").dialog({
        autoOpen: false,
        width: 400,
        buttons: [
            {
                text: "Ok",
                click: function () {
                    $(this).dialog("close");
                }
            },
            {
                text: "Cancel",
                click: function () {
                    $(this).dialog("close");
                }
            }
        ]
    });
}

$().ready(function () {
    $('#dialog').dialog({
        autoOpen: false,
        modal: true,
        bgiframe: true,
        title: "Atenticación de Usuario",
        width: 425,
        height: 180
    });
});
function rowAction(uniqueID) {
    $('#dialog').dialog('option', 'buttons',
        {
            "Aceptar": function () { $(this).dialog("close"); }
            //,
            //"No Acepto": function () { $(this).dialog("close"); }
        });
    $('#dialog').dialog('open');
    return false;
}


//function Validate() {
//    var messageId = "<%= Label1.ClientID %>";
//    var message = document.getElementById(messageId);

//    var UsernameId = "<%= Username.ClientID %>";
//    var userName = document.getElementById("Username");
//    if (userName != null) {
//        if (userName.value.length = 0) {
//            message.value = "Datos raros"
//            message.innerHTML = "Datos raros";
//            message.innerText = "Datos raros";
//        }
//    }

//    var PasswordId = "<%= Password.ClientID %>";
//    var password = document.getElementById("Password");
//    if (password != null) {
//        if (password.innerText = "") {
//            message.value = "Datos raros";
//            message.innerHTML = "Datos raros";
//            message.innerText = "Datos raros";
//        }
//    }
//}

