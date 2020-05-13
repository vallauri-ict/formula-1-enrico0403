"use strict;"

$(function () {
    $("#img").on("click", function () {
        window.location.reload();
    });
    let _wrapper = $("#wrapper");

    $("#loadRaces").on("click", function () {
        window.scrollTo({ top: 0, behavior: 'smooth' });
        $("#navbar ul li input").css("background-color", "inherit");
        $("#loadRaces").css("background-color", "rgba(0,0,0,0.3)");
        richiesta("/races", function (data) {
            _wrapper.html("<fieldset><h1>F1 2019 Races</h1></fieldset>");
            console.log(data);
            let _div = $("<div>")
                .addClass("race")
                .appendTo(_wrapper);
            for (let race of data) {
                let _fs = $("<fieldset>")
                    .addClass("race")
                    .data("id", race.id)
                    .data("open", "false")
                    .appendTo(_div);

                $("<p>")
                    .html(race.name)
                    .addClass("name")
                    .appendTo(_fs);

                let date = new Date(race.date);
                let dateString = date.getDate() + '/' + (date.getMonth() + 1) + '/' + date.getFullYear();
                $("<p>")
                    .html(race.circuit["name"] + ', (' + race.circuit.country["countryCode"] + ') - ' + dateString)
                    .addClass("circuitname")
                    .appendTo(_fs);
            }
        });
    });

    $("#loadDrivers").on("click", function () {
        window.scrollTo({top: 0, behavior: 'smooth'});
        $("#navbar ul li input").css("background-color","inherit");
        $("#loadDrivers").css("background-color","rgba(0,0,0,0.3)");
        richiesta("/drivers", function (data) {
            _wrapper.html("<fieldset><h1>F1 2019 Drivers</h1></fieldset>");
            console.log(data);
            let _div=$("<div>")
            .addClass("driver")
            .appendTo(_wrapper);
            for(let driver of data)
            {
                let _fs=$("<fieldset>")
                .addClass("driver")
                .data("id",driver.id)
                .appendTo(_div);

                $("<span>")
                .html(driver.firstname)
                .addClass("firstname")
                .appendTo(_fs);

                $("<span>")
                .html(driver.lastname)
                .addClass("lastname")
                .appendTo(_fs);

                $("<hr>")
                .addClass("hr")
                    .appendTo(_fs);

                $("<p class='driver'>")
                    .html("Place of Birthday: "+driver.placeOfBirthday + ", " + driver.country["countryCode"])
                    .data("countryCode", driver.country["countryName"])
                    .appendTo(_fs);
                $("<p class='driverSecond'>")
                    .html("Date of Birthday: " + new Date(driver.dob).toLocaleDateString()).appendTo(_fs);

                $("<img style='width: 150px; height: 150px;'>")
                .prop("src",driver.img)
                .addClass("img")
                .appendTo(_fs);            
            }
        });
    });

    $("#loadTeams").on("click", function () {
        window.scrollTo({top: 0, behavior: 'smooth'});
        $("#navbar ul li input").css("background-color","inherit");
        $("#loadTeams").css("background-color","rgba(0,0,0,0.3)");
        richiesta("/teams", function (data) {
            _wrapper.html("<fieldset><h1>F1 2019 Teams</h1></fieldset>");
            console.log(data);
            let _div=$("<div>")
            .addClass("team")
            .appendTo(_wrapper);
            for(let team of data)
            {
                let _fs=$("<fieldset>")
                .addClass("team")
                .data("id",team.id)
                .appendTo(_div);

                $("<p class='name'>")
                    .text(team.name)
                    .data("name", team.name)
                    .appendTo(_fs);
                $("<p class='data'>")
                    .text("First driver: "+team.firstDriver["firstname"] + " " + team.firstDriver["lastname"])
                    .data("firstname", team.firstDriver["firstname"])
                    .appendTo(_fs);

                $("<p class='dataSecond'>")
                    .text("Second driver: " + team.secondDriver["firstname"] + " " + team.secondDriver["lastname"])
                    .data("firstname", team.secondDriver["firstname"])
                    .appendTo(_fs);

                $("<img style='width: 300px; height: 100px'>")
                .prop("src",team.img)
                .addClass("img")
                .appendTo(_fs);

                $("<img>")
                .prop("src",team.logo)
                .addClass("logo")
                .appendTo(_fs);
            }
        });
    });

    $("#loadCircuits").on("click", function () {
        window.scrollTo({top: 0, behavior: 'smooth'});
        $("#navbar ul li input").css("background-color","inherit");
        $("#loadCircuits").css("background-color","rgba(0,0,0,0.3)");
        richiesta("/circuits/", function (data) {
            _wrapper.html("<fieldset><h1>F1 2019 Circuits</h1></fieldset>");
            let _div=$("<div>")
            .addClass("circuit")
            .appendTo(_wrapper);
            for(let circuit of data)
            {
                let _fs=$("<fieldset>")
                .addClass("circuit")
                .data("id",circuit.id)
                .appendTo(_div);

                $("<span>")
                .html(circuit.name)
                .addClass("name")
                .appendTo(_fs);
                $("<span>")
                .html(circuit.country.countryName)
                .addClass("country")
                .appendTo(_fs);
                $("<span>")
                .html((circuit.length/1000)+"km")
                .addClass("length")
                .appendTo(_fs);
                $("<span>")
                .html("Laps: "+circuit.nLaps)
                .addClass("nLaps")
                .appendTo(_fs);
                $("<hr>")
                .addClass("hr")
                .appendTo(_fs);
                $("<img style='width: 380px; height: 380px'; margin-right: 40px>")
                    .prop("src", circuit.img)
                    .addClass("img").appendTo(_fs);
            }
        });
    });
});

function richiesta(parameters,callbackFunction) {
    let _richiesta = $.ajax({
        url: "api" + parameters,
        type: "GET",
        data: "",
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        dataType: "json",
        timeout: 5000,
    });

    _richiesta.done(callbackFunction);
    _richiesta.fail(error);
}

function loadTable(data) {
    let tbl_body = "";
    let tbl_head = "";
    let odd_even = false;
    let first = true;
    $.each(data, function () {
        let tbl_row = "";

        $.each(this, function (k, v) {
            if (first) {
                tbl_head += "<th>" + k + "</th>";
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
        tbl_body += "<tr class=\"" + (odd_even ? "odd" : "even") + "\">" + tbl_row + "</tr>";
        odd_even = !odd_even;
    });
    $("#table thead").html(tbl_head);
    $("#table tbody").html(tbl_body);
};
function loadElement(data) {
    console.log(data);
    let tbl_body = "";
    let tbl_head = "";

    $.each(data, function (k, v) {
        tbl_head += "<th>" + k + "</th>";

        if (({}).constructor === v.constructor)
        {
            for (var key in v) {
                if (v.hasOwnProperty(key)) {
                    tbl_body += "<td>" + v[key] + "</td>";
                    break;
                }
            }
        }
        else
            tbl_body += "<td>" + v + "</td>";
    });
    $("#table thead").html(tbl_head);
    $("#table tbody").html(tbl_body);
};

function error(jqXHR, testStatus, strError) {
    $("#table thead").html("");
    $("#table tbody").html("Impossibile trovare la risorsa richiesta, per ulteriori informazioni consultare a la console (F12).");
    if (jqXHR.status == 0)
        console.log("Server Timeout");
    else if (jqXHR.status == 200)
        console.log("Formato dei dati non corretto: " + jqXHR.responseText);
    else
        console.log("Server Error: " + jqXHR.status + " - " + jqXHR.responseText);
};