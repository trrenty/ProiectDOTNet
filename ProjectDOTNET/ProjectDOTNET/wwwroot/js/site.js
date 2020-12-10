// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
    var canvas, ctx, flag = false,
    prevX = 0,
    currX = 0,
    prevY = 0,
    currY = 0,
    dot_flag = false;

    var x = "black",
    y = 4;

    function init() {
        resizeCanvas();
        canvas = document.getElementById('can');
        ctx = canvas.getContext("2d");
        w = canvas.width;
        h = canvas.height;

        console.log(w);
        console.log(h);

        canvas.addEventListener("mousemove", function (e) {
        findxy('move', e)
    }, false);
        canvas.addEventListener("mousedown", function (e) {
        findxy('down', e)
    }, false);
        canvas.addEventListener("mouseup", function (e) {
        findxy('up', e)
    }, false);
        canvas.addEventListener("mouseout", function (e) {
        findxy('out', e)
    }, false);
    }

    function color(obj) {
        switch (obj.id) {
            case "green":
                x = "green";
                break;
            case "blue":
                x = "blue";
                break;
            case "red":
                x = "red";
                break;
            case "yellow":
                x = "yellow";
                break;
            case "orange":
                x = "orange";
                break;
            case "black":
                x = "black";
                break;
            case "white":
                x = "white";
                break;
        }
        if (x == "white") y = 32;
        else y = 4;

    }

    function draw() {
        ctx.beginPath();
        ctx.moveTo(prevX, prevY);
        ctx.lineTo(currX, currY);
        ctx.strokeStyle = x;
        ctx.lineWidth = y;
        ctx.stroke();
        ctx.closePath();
    }
    function resizeCanvas() {
        var canvs = document.getElementById("can");
        var container = document.getElementsByClassName("container")[0].offsetWidth;
        canvs.width = container - 33;
    }

    function erase() {
        var m = confirm("Want to clear");
        if (m) {
        ctx.clearRect(0, 0, w, h);
            document.getElementById("canvasimg").style.display = "none";
        }
    }

    function save() {
        document.getElementById("canvasimg").style.border = "2px solid";
        var dataURL = canvas.toDataURL();
        document.getElementById("canvasimg").src = dataURL;
        console.log(dataURL);
        document.getElementById("canvasimg").style.display = "inline";
    }

function findxy(res, e) {
    var offsetLeft = document.getElementById("canvasContainer").offsetLeft;
    var offsetDown = document.getElementById("canvasContainer").offsetTop;

        if (res == 'down') {
        prevX = currX;
            prevY = currY;
            currX = e.clientX - offsetLeft;
            currY = e.clientY - offsetDown;

            console.log(canvas.offsetLeft);

            flag = true;
            dot_flag = true;
            if (dot_flag) {
        ctx.beginPath();
                ctx.fillStyle = x;
                ctx.fillRect(currX, currY, 2, 2);
                ctx.closePath();
                dot_flag = false;
            }
        }
        if (res == 'up' || res == "out") {
        flag = false;
        }
        if (res == 'move') {
            if (flag) {
        prevX = currX;
                prevY = currY;
                currX = e.clientX - offsetLeft;
                currY = e.clientY - offsetDown;
                draw();
            }
        }
    }

function sendPostRequestToImageRecognizer() {
    //Sending and receiving data in JSON format using POST method
    var xhr = new XMLHttpRequest();
    var url = "url"; // Image Recognizer
    xhr.open("POST", url, true);
    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            var json = JSON.parse(xhr.responseText);
            console.log(json.email + ", " + json.password);
        }
    };
    var data = JSON.stringify({ "email": "hey@mail.com", "password": "101010" });
    //xhr.send(data);
    xhr.send("Json primit");

    //search equation in the database


    //send request to equation server
    var xhr = new XMLHttpRequest();
    var url = "url"; // EquationSolver
    xhr.open("POST", url, true);
    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            var json = JSON.parse(xhr.responseText);
            console.log(json.email + ", " + json.password);
        }
    };
    var data = JSON.stringify({ "email": "hey@mail.com", "password": "101010" });
    //xhr.send(data);
    xhr.send("Json primit de la EquationSolver");
}