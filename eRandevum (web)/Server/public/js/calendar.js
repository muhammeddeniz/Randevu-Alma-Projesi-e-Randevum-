
let today = new Date();
let currebtMonth = today.getMonth();
let currentYear = today.getFullYear();

var temp = [];
var tarih = "";

let months = [
    "Ocak",
    "Şubat",
    "Mart",
    "Nisan",
    "Mayıs",
    "Haziran",
    "Temmuz",
    "Ağustos",
    "Eylül",
    "Ekim",
    "Kasım",
    "Aralık"
];

let monthAndYear = document.getElementById("monthAndYear");
takvimGoster(currebtMonth, currentYear);
var saat;
var yil;
var gun; 
var ay;

function takvimGoster(month, year) {
    let firstDay = new Date(year, month).getDay();
    let daysInMonth = 32 - new Date(year, month, 32).getDate();


    let tbl = document.getElementById('calendar-body');

    tbl.innerHTML = "";

    monthAndYear.innerHTML = months[month] + " " + year;

    let date = 1;

    for (let i = 0; i < 6; i++) {
        let row = document.createElement('tr');
        for (let j = 0; j < 7; j++) {
            if (i === 0 && j < firstDay) {
                let cell = document.createElement('td');
                let cellText = document.createTextNode('');

                cell.appendChild(cellText);
                row.appendChild(cell);

            } else if (date > daysInMonth) {
                break;

            } else {
                let cell = document.createElement("td");

                let cellText = document.createTextNode(date);

                cell.addEventListener("click", function () {

                    temp.push(cell);

                    for (var i = 0; i < temp.length; i++) {
                        temp[i].style.background = "white";
                    }

                    if (cellText.textContent == row.firstChild.textContent || cellText.textContent == row.lastChild.textContent ) {
                        alert("Cumartesi ve Pazar Günleri Randevu Alamzsınız.");

                    } else {
                       yil = year;
                       ay = Number(month + 1);
                       gun = cellText.textContent;

                        tarih = "Gün : " + cellText.textContent + " \nAy : " + Number(month + 1) + "\nYıl : " + year;
                        cell.style.background = "red";
                    }
                });


                cell.appendChild(cellText);
                row.appendChild(cell);
                date++;
            }
        }
        tbl.appendChild(row);
    }
}

function previous() {
    currentYear = currebtMonth === 0 ? currentYear - 1 : currentYear;
    currebtMonth = currebtMonth === 0 ? 11 : currebtMonth - 1;

    takvimGoster(currebtMonth, currentYear);

}


function next() {
    currentYear = currebtMonth === 11 ? currentYear + 1 : currentYear;
    currebtMonth = (currebtMonth + 1) % 12;

    takvimGoster(currebtMonth, currentYear);
}

function f1(temp) {
    document.getElementById("btn1").className = "btn btn-warning";
    document.getElementById("btn2").className = "btn btn-success";
    document.getElementById("btn3").className = "btn btn-success";
    document.getElementById("btn4").className = "btn btn-success";
    document.getElementById("btn5").className = "btn btn-success";
    document.getElementById("btn6").className = "btn btn-success";
    document.getElementById("btn7").className = "btn btn-success";
    document.getElementById("btn8").className = "btn btn-success";
    saat = temp;
}
function f2(temp) {
    document.getElementById("btn1").className = "btn btn-success";
    document.getElementById("btn2").className = "btn btn-warning";
    document.getElementById("btn3").className = "btn btn-success";
    document.getElementById("btn4").className = "btn btn-success";
    document.getElementById("btn5").className = "btn btn-success";
    document.getElementById("btn6").className = "btn btn-success";
    document.getElementById("btn7").className = "btn btn-success";
    document.getElementById("btn8").className = "btn btn-success";
    saat = temp;
    saat = temp;
}
function f3(temp) {
    document.getElementById("btn1").className = "btn btn-success";
    document.getElementById("btn2").className = "btn btn-success";
    document.getElementById("btn3").className = "btn btn-warning";
    document.getElementById("btn4").className = "btn btn-success";
    document.getElementById("btn5").className = "btn btn-success";
    document.getElementById("btn6").className = "btn btn-success";
    document.getElementById("btn7").className = "btn btn-success";
    document.getElementById("btn8").className = "btn btn-success";
    saat = temp;
}
function f4(temp) {
    document.getElementById("btn1").className = "btn btn-success";
    document.getElementById("btn2").className = "btn btn-success";
    document.getElementById("btn3").className = "btn btn-success";
    document.getElementById("btn4").className = "btn btn-warning";
    document.getElementById("btn5").className = "btn btn-success";
    document.getElementById("btn6").className = "btn btn-success";
    document.getElementById("btn7").className = "btn btn-success";
    document.getElementById("btn8").className = "btn btn-success";
    saat = temp;
}
function f5(temp) {
    document.getElementById("btn1").className = "btn btn-success";
    document.getElementById("btn2").className = "btn btn-success";
    document.getElementById("btn3").className = "btn btn-success";
    document.getElementById("btn4").className = "btn btn-success";
    document.getElementById("btn5").className = "btn btn-warning";
    document.getElementById("btn6").className = "btn btn-success";
    document.getElementById("btn7").className = "btn btn-success";
    document.getElementById("btn8").className = "btn btn-success";
    saat = temp;
}
function f6(temp) {
    document.getElementById("btn1").className = "btn btn-success";
    document.getElementById("btn2").className = "btn btn-success";
    document.getElementById("btn3").className = "btn btn-success";
    document.getElementById("btn4").className = "btn btn-success";
    document.getElementById("btn5").className = "btn btn-success";
    document.getElementById("btn6").className = "btn btn-warning";
    document.getElementById("btn7").className = "btn btn-success";
    document.getElementById("btn8").className = "btn btn-success";
    saat = temp;
}
function f7(temp) {
    document.getElementById("btn1").className = "btn btn-success";
    document.getElementById("btn2").className = "btn btn-success";
    document.getElementById("btn3").className = "btn btn-success";
    document.getElementById("btn4").className = "btn btn-success";
    document.getElementById("btn5").className = "btn btn-success";
    document.getElementById("btn6").className = "btn btn-success";
    document.getElementById("btn7").className = "btn btn-warning";
    document.getElementById("btn8").className = "btn btn-success";
    saat = temp;
}
function f8(temp) {
    document.getElementById("btn1").className = "btn btn-success";
    document.getElementById("btn2").className = "btn btn-success";
    document.getElementById("btn3").className = "btn btn-success";
    document.getElementById("btn4").className = "btn btn-success";
    document.getElementById("btn5").className = "btn btn-success";
    document.getElementById("btn6").className = "btn btn-success";
    document.getElementById("btn7").className = "btn btn-success";
    document.getElementById("btn8").className = "btn btn-warning";
    saat = temp;
}

function goster() {
    alert(tarih + "\nSaat : " + saat);
    $("input[name *= 'rYili']").val(yil);
    $("input[name *= 'rAyi']").val(ay);
    $("input[name *= 'rGunu']").val(gun);
    $("input[name *= 'rSaati']").val(saat);
    
    alert("Randevunuz Onay Beklemektedir.\nYetkili Tarafından Onaylandığında Randevularım bölümünden bulabilirsinizs.")
}

