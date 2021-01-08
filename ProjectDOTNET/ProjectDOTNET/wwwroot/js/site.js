// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
    var canvas1,canvas2,canvas3,canvas4,canvas5,canvas6, ctx1,ctx2,ctx3,ctx4,ctx5,ctx6, flag1=false,flag2=false,flag3=false,flag4=false,flag5=false,flag6 = false,
    prevX1 = 0,
    currX1 = 0,
    prevY1= 0,
    currY1 = 0,
    dot_flag1 = false,
    prevX2 = 0,
    currX2 = 0,
    prevY2 = 0,
    currY2 = 0,
    dot_flag2 = false,
prevX3 = 0,
    currX3 = 0,
    prevY3 = 0,
    currY3 = 0,
    dot_flag3 = false,
prevX4 = 0,
    currX4 = 0,
    prevY4 = 0,
    currY4 = 0,
    dot_flag4 = false,
prevX5 = 0,
    currX5 = 0,
    prevY5 = 0,
    currY5 = 0,
    dot_flag5 = false,
prevX6 = 0,
    currX6 = 0,
    prevY6 = 0,
    currY6 = 0,
    dot_flag6 = false;

    var x = "black",
    y = 4;

function init() {
        canvas1 = document.getElementById('can1');
        ctx1 = canvas1.getContext("2d");
        w1= canvas1.width;
        h1= canvas1.height;
        console.log(w1);
        console.log(h1);
        canvas1.addEventListener("mousemove", function (e) {
            findxy('move', e, 1)
        }, false);
        canvas1.addEventListener("mousedown", function (e) {
            findxy('down', e, 1)
        }, false);
        canvas1.addEventListener("mouseup", function (e) {
            findxy('up', e, 1)
        }, false);
        canvas1.addEventListener("mouseout", function (e) {
            findxy('out', e, 1)
        }, false);
     
        canvas2 = document.getElementById('can2');
        ctx2 = canvas2.getContext("2d");
        w2 = canvas2.width;
        h2 = canvas2.height;
        console.log(w2);
        console.log(h2);


        canvas2.addEventListener("mousemove", function (e) {
            findxy('move', e, 2)
        }, false);
        canvas2.addEventListener("mousedown", function (e) {
            findxy('down', e, 2)
        }, false);
        canvas2.addEventListener("mouseup", function (e) {
            findxy('up', e, 2)
        }, false);
        canvas2.addEventListener("mouseout", function (e) {
            findxy('out', e, 2)
        }, false);
      
        canvas3 = document.getElementById('can3');
        ctx3 = canvas3.getContext("2d");
        w3 = canvas3.width;
        h3 = canvas3.height;
        console.log(w3);
        console.log(h3);
        
        canvas3.addEventListener("mousemove", function (e) {
            findxy('move', e,3)
        }, false);
        canvas3.addEventListener("mousedown", function (e) {
            findxy('down', e,3)
        }, false);
        canvas3.addEventListener("mouseup", function (e) {
            findxy('up', e,3)
        }, false);
        canvas3.addEventListener("mouseout", function (e) {
            findxy('out', e,3)
        }, false);

   
        canvas4 = document.getElementById('can4');
        ctx4 = canvas4.getContext("2d");
        w4 = canvas4.width;
        h4 = canvas4.height;
        console.log(w4);
        console.log(h4);

      
        canvas5 = document.getElementById('can5');
        ctx5 = canvas5.getContext("2d");
        w5 = canvas5.width;
        h5 = canvas5.height;
        console.log(w5);
        console.log(h5);

    
        canvas6 = document.getElementById('can6');
        ctx6 = canvas6.getContext("2d");
        w6 = canvas6.width;
        h6 = canvas6.height;
        console.log(w6);
        console.log(h6);
        /*[document.querySelector('#can1'), document.querySelector('#can2'), document.querySelector('#can3'), document.querySelector('#can4'), document.querySelector('#can5'), document.querySelector('#can6')
        ].forEach(item => {
            item.addEventListener("mousemove", function (e) {
                findxy('move', e)
            }, false);
        })
        [document.querySelector('#can1'), document.querySelector('#can2'), document.querySelector('#can3'), document.querySelector('#can4'), document.querySelector('#can5'), document.querySelector('#can6')
        ].forEach(item => {
            item.addEventListener("mousedown", function (e) {
                findxy('down', e)
            }, false);
        })
        [document.querySelector('#can1'), document.querySelector('#can2'), document.querySelector('#can3'), document.querySelector('#can4'), document.querySelector('#can5'), document.querySelector('#can6')
        ].forEach(item => {
            item.addEventListener("mouseup", function (e) {
                findxy('up', e)
            }, false);
        })
        [document.querySelector('#can1'), document.querySelector('#can2'), document.querySelector('#can3'), document.querySelector('#can4'), document.querySelector('#can5'), document.querySelector('#can6')
        ].forEach(item => {
            item.addEventListener("mouseout", function (e) {
                findxy('out', e)
            }, false);
        })
        
        */


        canvas4.addEventListener("mousemove", function (e) {
            findxy('move', e,4)
        }, false);
        canvas4.addEventListener("mousedown", function (e) {
            findxy('down', e,4)
        }, false);
        canvas4.addEventListener("mouseup", function (e) {
            findxy('up', e,4)
        }, false);
        canvas4.addEventListener("mouseout", function (e) {
            findxy('out', e,4)
        }, false);

        canvas5.addEventListener("mousemove", function (e) {
            findxy('move', e,5)
        }, false);
        canvas5.addEventListener("mousedown", function (e) {
            findxy('down', e,5)
        }, false);
        canvas5.addEventListener("mouseup", function (e) {
            findxy('up', e,5)
        }, false);
        canvas5.addEventListener("mouseout", function (e) {
            findxy('out', e,5)
        }, false);

        canvas6.addEventListener("mousemove", function (e) {
            findxy('move', e,6)
        }, false);
        canvas6.addEventListener("mousedown", function (e) {
            findxy('down', e,6)
        }, false);
        canvas6.addEventListener("mouseup", function (e) {
            findxy('up', e,6)
        }, false);
        canvas6.addEventListener("mouseout", function (e) {
            findxy('out', e,6)
        }, false);
        
       
    }

    function color(obj) {
        switch (obj.id) {
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
function resizeCanvas() {
    var canvs = document.etElementsByClassName("can");
    var container = document.getElementsByClassName("canvasContainer")[0].offsetWidth;
    canvs.width = container - 33;
}
function draw(nr) {
     if (nr == 2) {
        ctx2.beginPath();
        ctx2.moveTo(prevX2, prevY2);
        ctx2.lineTo(currX2, currY2);
        ctx2.strokeStyle = x;
        ctx2.lineWidth = y;
        ctx2.stroke();
        ctx2.closePath();
    }
    else if (nr == 1) {
        ctx1.beginPath();
        ctx1.moveTo(prevX1, prevY1);
        ctx1.lineTo(currX1, currY1);
        ctx1.strokeStyle = x;
        ctx1.lineWidth = y;
        ctx1.stroke();
        ctx1.closePath();
    }
    else if(nr == 3) {
        ctx3.beginPath();
        ctx3.moveTo(prevX3, prevY3);
        ctx3.lineTo(currX3, currY3);
        ctx3.strokeStyle = x;
        ctx3.lineWidth = y;
        ctx3.stroke();
        ctx3.closePath();
    }
    else if(nr == 4){
        ctx4.beginPath();
        ctx4.moveTo(prevX4, prevY4);
        ctx4.lineTo(currX4, currY4);
        ctx4.strokeStyle = x;
        ctx4.lineWidth = y;
        ctx4.stroke();
        ctx4.closePath();
    }
     else if (nr == 5) {
         ctx5.beginPath();
         ctx5.moveTo(prevX5, prevY5);
         ctx5.lineTo(currX5, currY5);
         ctx5.strokeStyle = x;
         ctx5.lineWidth = y;
         ctx5.stroke();
         ctx5.closePath();
    }
     else {
         ctx6.beginPath();
         ctx6.moveTo(prevX6, prevY6);
         ctx6.lineTo(currX6, currY6);
         ctx6.strokeStyle = x;
         ctx6.lineWidth = y;
         ctx6.stroke();
         ctx6.closePath();
     }
    }


    function erase() {
        var m = confirm("Want to clear");
        if (m) {
        ctx1.clearRect(0, 0, w1, h1);
            ctx2.clearRect(0, 0, w2, h2);
            ctx3.clearRect(0, 0, w3, h3);
            ctx4.clearRect(0, 0, w4, h4);
            ctx5.clearRect(0, 0, w5, h5);
            ctx6.clearRect(0, 0, w6, h6);
        }
    }
/*
function save() {
        document.getElementById("canvasimg1").style.border = "2px solid";
        var dataURL = canvas1.toDataURL();
        document.getElementById("canvasimg1").src = dataURL;
        console.log(dataURL);
        document.getElementById("canvasimg1").style.display = "inline";

        document.getElementById("canvasimg2").style.border = "2px solid";
        var dataURL = canvas2.toDataURL();
        document.getElementById("canvasimg2").src = dataURL;
        console.log(dataURL);
        document.getElementById("canvasimg2").style.display = "inline";

        document.getElementById("canvasimg3").style.border = "2px solid";
        var dataURL = canvas3.toDataURL();
        document.getElementById("canvasimg3").src = dataURL;
        console.log(dataURL);
        document.getElementById("canvasimg3").style.display = "inline";

        document.getElementById("canvasimg4").style.border = "2px solid";
        var dataURL = canvas4.toDataURL();
        document.getElementById("canvasimg4").src = dataURL;
        console.log(dataURL);
        document.getElementById("canvasimg4").style.display = "inline";

        document.getElementById("canvasimg5").style.border = "2px solid";
        var dataURL = canvas5.toDataURL();
        document.getElementById("canvasimg5").src = dataURL;
        console.log(dataURL);
        document.getElementById("canvasimg5").style.display = "inline";

        document.getElementById("canvasimg6").style.border = "2px solid";
        var dataURL = canvas6.toDataURL();
        document.getElementById("canvasimg6").src = dataURL;
        console.log(dataURL);
        document.getElementById("canvasimg6").style.display = "inline";
    }
    */

function findxy(res, e, nr) {
      if (nr == 2) {
        var offsetLeft = document.getElementById("can2").offsetLeft;
        var offsetTop = document.getElementById("can2").offsetTop;
        if (res == 'down') {
            prevX2 = currX2;
            prevY2 = currY2;
            currX2 = e.clientX - offsetLeft;
            currY2 = e.clientY - offsetTop;

            console.log(canvas2.offsetLeft);

            flag2 = true;
            dot_flag2 = true;
            if (dot_flag2) {
                ctx2.beginPath();
                ctx2.fillStyle = x;
                ctx2.fillRect(currX2, currY2, 2, 2);
                ctx2.closePath();
                dot_flag2 = false;
            }
        }
        if (res == 'up' || res == "out") {
            flag2 = false;
        }
        if (res == 'move') {
            if (flag2) {
                prevX2 = currX2;
                prevY2 = currY2;
                currX2 = e.clientX - offsetLeft;
                currY2 = e.clientY - offsetTop;
                draw(2);
            }
        }
    }
   else if (nr == 1) {
        var offsetLeft = document.getElementById("can1").offsetLeft;
        var offsetTop = document.getElementById("can1").offsetTop;
        if (res == 'down') {
            prevX1 = currX1;
            prevY1 = currY1;
            currX1 = e.clientX - offsetLeft;
            currY1 = e.clientY - offsetTop;

            console.log(canvas1.offsetLeft);

            flag1 = true;
            dot_flag1 = true;
            if (dot_flag1) {
                ctx1.beginPath();
                ctx1.fillStyle = x;
                ctx1.fillRect(currX1, currY1, 2, 2);
                ctx1.closePath();
                dot_flag1 = false;
            }
        }
        if (res == 'up' || res == "out") {
            flag1 = false;
        }
        if (res == 'move') {
            if (flag1) {
                prevX1 = currX1;
                prevY1 = currY1;
                currX1 = e.clientX - offsetLeft;
                currY1 = e.clientY - offsetTop;
                draw(1);
            }
        }
    }
    else if(nr == 3){
        var offsetLeft = document.getElementById("can3").offsetLeft;
        var offsetTop = document.getElementById("can3").offsetTop;
        if (res == 'down') {
            prevX3 = currX3;
            prevY3= currY3;
            currX3 = e.clientX - offsetLeft;
            currY3 = e.clientY - offsetTop;

            console.log(canvas3.offsetLeft);

            flag3 = true;
            dot_flag3 = true;
            if (dot_flag3) {
                ctx3.beginPath();
                ctx3.fillStyle = x;
                ctx3.fillRect(currX3, currY3, 2, 2);
                ctx3.closePath();
                dot_flag3 = false;
            }
        }
        if (res == 'up' || res == "out") {
            flag3 = false;
        }
        if (res == 'move') {
            if (flag3) {
                prevX3 = currX3;
                prevY3 = currY3;
                currX3 = e.clientX - offsetLeft;
                currY3 = e.clientY - offsetTop;
                draw(3);
            }
        }
    }
      else if (nr == 4) {
          var offsetLeft = document.getElementById("can4").offsetLeft;
          var offsetTop = document.getElementById("can4").offsetTop;
          if (res == 'down') {
              prevX4 = currX4;
              prevY4 = currY4;
              currX4 = e.clientX - offsetLeft;
              currY4 = e.clientY - offsetTop;

              console.log(canvas4.offsetLeft);

              flag4 = true;
              dot_flag4 = true;
              if (dot_flag4) {
                  ctx4.beginPath();
                  ctx4.fillStyle = x;
                  ctx4.fillRect(currX4, currY4, 2, 2);
                  ctx4.closePath();
                  dot_flag4 = false;
              }
          }
          if (res == 'up' || res == "out") {
              flag4 = false;
          }
          if (res == 'move') {
              if (flag4) {
                  prevX4 = currX4;
                  prevY4 = currY4;
                  currX4 = e.clientX - offsetLeft;
                  currY4 = e.clientY - offsetTop;
                  draw(4);
              }
          }
      }
      else if (nr == 5) {
          var offsetLeft = document.getElementById("can5").offsetLeft;
          var offsetTop = document.getElementById("can5").offsetTop;
          if (res == 'down') {
              prevX5 = currX5;
              prevY5 = currY5;
              currX5 = e.clientX - offsetLeft;
              currY5 = e.clientY - offsetTop;

              console.log(canvas3.offsetLeft);

              flag5 = true;
              dot_flag5 = true;
              if (dot_flag5) {
                  ctx5.beginPath();
                  ctx5.fillStyle = x;
                  ctx5.fillRect(currX5, currY5, 2, 2);
                  ctx5.closePath();
                  dot_flag5 = false;
              }
          }
          if (res == 'up' || res == "out") {
              flag5 = false;
          }
          if (res == 'move') {
              if (flag5) {
                  prevX5 = currX5;
                  prevY5 = currY5;
                  currX5 = e.clientX - offsetLeft;
                  currY5 = e.clientY - offsetTop;
                  draw(5);
              }
          }
      }
      else {
          var offsetLeft = document.getElementById("can6").offsetLeft;
          var offsetTop = document.getElementById("can6").offsetTop;
          if (res == 'down') {
              prevX6 = currX6;
              prevY6 = currY6;
              currX6 = e.clientX - offsetLeft;
              currY6 = e.clientY - offsetTop;

              console.log(canvas6.offsetLeft);

              flag6 = true;
              dot_flag6 = true;
              if (dot_flag6) {
                  ctx6.beginPath();
                  ctx6.fillStyle = x;
                  ctx6.fillRect(currX6, currY6, 2, 2);
                  ctx6.closePath();
                  dot_flag6 = false;
              }
          }
          if (res == 'up' || res == "out") {
              flag6 = false;
          }
          if (res == 'move') {
              if (flag6) {
                  prevX6 = currX6;
                  prevY6 = currY6;
                  currX6 = e.clientX - offsetLeft;
                  currY6 = e.clientY - offsetTop;
                  draw(6);
              }
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
