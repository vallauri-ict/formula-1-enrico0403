"use strict;"

$(function () {
    $("#caricaDrivers").on("click", function () {
        richiesta("/Drivers", loadTable);
    });

    $("#caricaTeams").on("click", function () {
        richiesta("/Teams", loadTable);
    });

    $("#caricaCountries").on("click", function () {
        richiesta("/Countries", loadTable);
    });
    
    $("#caricaDriver").on("click", function () {
        let driverId = $("#txtDriver").val();
        richiesta("/Drivers/" + driverId, loadElement);
    });
    $("#caricaTeam").on("click", function () {
        let teamId = $("#txtTeam").val();
        richiesta("/Teams/" + teamId, loadElement);
    });
    $("#caricaCountry").on("click", function () {
        let countryId = $("#txtCountry").val();
        richiesta("/Countries/" + countryId, loadElement);
    });
});

function richiesta(parameters,callBack) {
    let _richiesta = $.ajax({
        url: "api" + parameters,
        type: "GET",
        data: "",
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        dataType: "json",
        timeout: 5000,
    });

    _richiesta.done(callBack);
    _richiesta.fail(error);
}

function loadTable(data) {
    let tbBody = "";
    let tbHead = "";
    let odd_even = false;
    let first = true;
    $.each(data, function () {
        let tbl_row = "";

        $.each(this, function (k, v) {
            if (first) {
                tbHead += "<th>" + k + "</th>";
            }

            if (({}).constructor === v.constructor)
            {
                for (var key in v) {
                    if (v.hasOwnProperty(key)) {
                        tbl_row += "<td>" + v[key] + "</td>";
                        break;
                    }
                }
            }
            else
                tbl_row += "<td>" + v + "</td>";
        });
        first = false;
        tbBody += "<tr class=\"" + (odd_even ? "odd" : "even") + "\">" + tbl_row + "</tr>";
        odd_even = !odd_even;
    });
    $("#table thead").html(tbHead);
    $("#table tbody").html(tbBody);
};
function loadElement(data) {
    console.log(data);
    let tbBody = "";
    let tbHead = "";

    $.each(data, function (k, v) {
        tbHead += "<th>" + k + "</th>";

        if (({}).constructor === v.constructor)
        {
            for (var key in v) {
                if (v.hasOwnProperty(key)) {
                    tbBody += "<td>" + v[key] + "</td>";
                    break;
                }
            }
        }
        else
            tbBody += "<td>" + v + "</td>";
    });
    $("#table thead").html(tbHead);
    $("#table tbody").html(tbBody);
};

function error(jqXHR, testStatus, strError) {
    $("#table thead").html("");
    $("#table tbody").html("Impossibile trovare la risorsa richiesta, per maggiori informazioni in console.");
    if (jqXHR.status == 0)
        console.log("Server Timeout");
    else if (jqXHR.status == 200)
        console.log("Formato dei dati non corretto : " + jqXHR.responseText);
    else
        console.log("Server Error: " + jqXHR.status + " - " + jqXHR.responseText);
};