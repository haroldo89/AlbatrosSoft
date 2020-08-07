// ===================================================================================================
// Desarrollado Por		    :   Harold Caicedo.
// Fecha de Creación		:   2014/01/21.
// Producto o sistema	    :   NAVI10
// Empresa			        :   Wizenz Technologies
// Proyecto			        :   NAVI10
// Cliente			        :   Varios.
// ===================================================================================================
// Versión	        Descripción
// 1.0.0.0	        Funciones javascript de utilidad general para el modulo de mantenimiento.
// ===================================================================================================
// HISTORIAL DE CAMBIOS:
// ===================================================================================================
// Ver.	 Fecha		    Autor					Descripción
// ---	 -------------	----------------------	------------------------------------------------------
// XX	 yyyy/MM/dd	    [Nombre Completo]	    [Razón del cambio realizado] 
// ===================================================================================================

$(document).ready(function () {

    //Oculta el menu de login al dar clic en el div del contenido principal.
    $("#content").click(function (event) {
        hideLeftBarLogin();
    });

});

/** Impide se haga post cuando se presiona "enter" */
function noenter() {
    return !(window.event && window.event.keyCode === 13);
}

/*La funcion recibe el id control que se asocia para la edicion, y el validationGroup el cual esta 
    asociado el boton guardar
 */
function CreateConfirm(idControl, idGroup) {
    var txtControl = document.getElementById(idControl);
    if (idGroup != undefined) {
        //if (Page_ClientValidate(idGroup) == true) {
        if (txtControl.disabled) {
            var result = confirm("¿Esta seguro de realizar esta acción?");
            return result;
        }
        else {
            return true;
        }
        //}
        //else {
        //    return true;
        //}
    }
    else {
        if (txtControl.disabled) {
            var result = confirm("¿Esta seguro de realizar esta acción?");
            return result;
        }
        else {
            return true;
        }
    }
}

/*
Creacion de mensaje de confirmacion para eliminar
*/
function CreateConfirmDel(idControl, message) {
    var txtControl = document.getElementById(idControl);
    var valControl = txtControl.value;
    var result = confirm("¿" + message + valControl + "?");
    return result;
}

/** 
* Esconde la barra Izquierda 
*/
function hideLeftBar() {
    document.getElementById("navigationPage").setAttribute("style", "display:none");
    document.getElementById("liHideLeftBar").setAttribute("style", "display:none");
    document.getElementById("liShowLeftBar").setAttribute("style", "display:inline");
    document.getElementById("content").setAttribute("style", "left:0px");
}
/**
* Muestra la Barra izquierda
*/
function showLeftBar() {
    document.getElementById("navigationPage").setAttribute("style", "display:inline");
    document.getElementById("liHideLeftBar").setAttribute("style", "display:inline");
    document.getElementById("liShowLeftBar").setAttribute("style", "display:none");
    document.getElementById("content").setAttribute("style", "left:220px");
}


/*
Oculta la barra correspondiente al login 
*/
function hideLeftBarLogin() {
    document.getElementById("headerLogin").setAttribute("style", "display:none");
    document.getElementById("lnkCloseUser").setAttribute("style", "display:none");
    document.getElementById("lnkUser").setAttribute("style", "display:inline");
}

/*
Muestra la barra correspondiente al login 
*/
function showLeftBarLogin() {
    document.getElementById("headerLogin").setAttribute("style", "display:block");
    document.getElementById("lnkCloseUser").setAttribute("style", "display:inline");
    document.getElementById("lnkUser").setAttribute("style", "display:none");

    $("#headerLogin").position({
        my: "right top",
        at: "right top",
        of: "#mainLayout"
    });
}

/*
Muestra el panel de cargando en el SideBard
*/

function DisplayProgress() {
    var pnl = document.getElementById("pnlLoader");
    pnl.style.display = "block";
}


