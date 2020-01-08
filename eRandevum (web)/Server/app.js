var fs = require("fs");
var express = require("express");
var app = express();
var path = require("path");
var url = require("url");
var jsonFile = require('./public/public code/firmaBilgileri.json');
var bodyParser = require("body-parser");
var sql = require('mssql');
var cookie = require('cookie-parser');

app.use("/public", express.static(path.join(__dirname, "public")));
app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

var dbConfig = {
    server: "DESKTOP-4TL1V43\\SQLEXPRESS",
    database: "deneme",
    user: "deniz",
    password: "deniz",
    port: 1433
}


var fad = [];
var calisanbilgisi = [];
var firmagecmisi = [];
var randevudetayi = [];
var il = [];
var ilce = [];
var sokak = [];
var numara = [];
var telno = [];
var mail = [];
var route = [];

//ana sayfa 


var girilenID = 0;
//mest sayfasi
app.get("/anaSayfa/:id", function (req, res) {

    data = req.params.id;

    function getBlog() {
        var conn = new sql.ConnectionPool(dbConfig);
        var req = new sql.Request(conn);

        conn.connect(function (error) {
            if (error) {
                console.log(error);
                return;
            }

            req.query("SELECT * FROM Bilgiler", function (err, veri) {
                for (var i = 0; i < veri.recordset.length; i++) {
                    if (data == veri.recordset[i].router) {
                        girilenID = veri.recordset[i].IsyeriId;

                        res.render("firmaSayfasi.ejs", {

                            firmaGecmisi: veri.recordset[i].FirmaGecmisi,
                            calisanBilgisi: veri.recordset[i].CalisanBilgi,
                            randevuDetay: veri.recordset[i].RandevuDetayi,

                            il: veri.recordset[i].Il,
                            ilce: veri.recordset[i].Ilce,
                            sokak: veri.recordset[i].Sokak,
                            no: veri.recordset[i].No,

                            tel: veri.recordset[i].Tel,
                            mail: veri.recordset[i].Email,
                        });
                    }
                }
            });
        })
    }

    getBlog();

})



var id2 = 0;




//Randevu al butonu 
app.get("/randevuAl", function (req, res) {
    res.render("calendar.ejs", { randevular: "" });

})
/////////////////////////////////////////////////////////
// SQL BAĞLANTISI



//randevu bilgileri
app.post('/randevuAl', (req, res) => {
    var yıl = req.body.rYili;
    var ay = req.body.rAyi;
    var gun = req.body.rGunu;
    var saat = req.body.rSaati;



    var dbConfig = {
        server: "DESKTOP-4TL1V43\\SQLEXPRESS",
        database: "eRandevum",
        user: "deniz",
        password: "deniz",
        port: 1433
    }
    var deneme = "";
    function getBlog() {
        var conn = new sql.ConnectionPool(dbConfig);
        var req = new sql.Request(conn);

        conn.connect(function (error) {
            if (error) {
                console.log(error);
                return;
            }

            var tarih = gun + "." + ay + "." + yıl;

            req.query("SELECT * FROM Kullanici", function (err, veri) {
                for (var i = 0; i < veri.recordset.length; i++) {
                    if (kAdi == veri.recordset[i].Isim) {
                        id2 = veri.recordset[i].KullaniciId;
                    }
                }

            });


            req.query("SELECT * FROM Randevu", function (err, veri) {

                for (var i = 0; i < veri.recordset.length; i++) {

                    if (veri.recordset[i].RandevuTarih != tarih && veri.recordset[i].RandevuSaat != saat && veri.recordset.length - 1 === i) {
                        req.query("INSERT INTO Randevu(RandevuSaat, RandevuTarih, KullaniciId, IsyeriId) VALUES('" + String(saat) +
                            "' , '" + String(tarih) + "' , '" + String(id2) + "' , '" + String(girilenID) + "')");
                    } else if (veri.recordset.length - 1 === i) {
                        console.log("Böyle Bir Kayıt var.");
                    }
                }


            });

        })
    }
    res.render("calendar.ejs");

    getBlog();


});


var girisYapanYetkiliID = 0;
var girisTuru = "";
var girisYapanınIsyeriID = 0;

//login html sayfasi
app.get("/login", function (req, res) {
    res.render("giris.ejs", { hata: "" });
})

var girisTuru = "";
var kAdi = "";
var parola = "";
var yetkiliID = 0;


app.get("/anaSayfa", function (req, res) {
    var conn = new sql.ConnectionPool(dbConfig);
    var req = new sql.Request(conn);

    conn.connect(function (error) {
        if (error) {
            console.log(error);
            return;
        }
        fad = [];
        firmagecmisi = [];
        route = [];

        req.query("SELECT * FROM Bilgiler", function (err, veri) {
            for (var i = 0; i < veri.recordset.length; i++) {
                if (veri.recordset[i].IsyeriId > 30) {
                    fad.push(veri.recordset[i].IsyeriAdi);
                    firmagecmisi.push(veri.recordset[i].FirmaGecmisi);
                    route.push(veri.recordset[i].router);
                }
            }


            str = "";
            for (var j = 0; j < fad.length; j++) {
                str += "<div class='col-md-4'><div class='card mb-4 shadow-sm'>" +
                    "<img src='../public/mest.jpg' style='height: 310px;' alt='Mest Cafe'><title>Placeholder</title><rect width='100%' height='100%' fill='#55595c' /><text x='50%' y='50%' fill='#eceeef'" +
                    "dy='.3em' style='color: rgb(135, 8, 8); padding-left: 25%; '><b>" + fad[j] + "</b></text>" +
                    "<div class='card-body'><p style='font-family: Cambria;'>" + firmagecmisi[j] + "</p><div class='d-flex justify-content-between align-items-center'>" +
                    "<div class='btn-group'><a style='color: black;' href='/anaSayfa/" + route[j] + "'><button type='button'" +
                    "class='btn btn-sm btn-outline-primary'>Firmayı Ziyaret Et</button></a></div><small class='text-muted'>9 mins</small>" +
                    "</div></div></div></div>";
                console.log(route[j])
            }


            res.render("Ana Sayfa.ejs", {
                data: str,
            });

        });

    });

})



app.post("/anaSayfa", function (req, res) {
    girisTuru = req.body.secim;
    kAdi = req.body.kAdi;
    parola = req.body.parola;


    var dbConfig = {
        server: "DESKTOP-4TL1V43\\SQLEXPRESS",
        database: "eRandevum",
        user: "deniz",
        password: "deniz",
        port: 1433
    }

    function getBlog() {
        var conn = new sql.ConnectionPool(dbConfig);
        var req = new sql.Request(conn);

        conn.connect(function (error) {
            if (error) {
                console.log(error);
                return;
            }

            if (girisTuru === "kullanici") {
                req.query("SELECT * FROM Kullanici", function (err, veri) {
                    for (var i = 0; i < veri.recordset.length; i++) {

                        if (veri.recordset[i].Isim === kAdi && veri.recordset[i].Sifre === parola) {
                            var conn = new sql.ConnectionPool(dbConfig);
                            var req = new sql.Request(conn);

                            conn.connect(function (error) {
                                if (error) {
                                    console.log(error);
                                    return;
                                }
                                fad = [];
                                firmagecmisi = [];
                                route = [];

                                req.query("SELECT * FROM Bilgiler", function (err, veri) {
                                    for (var i = 0; i < veri.recordset.length; i++) {
                                        if (veri.recordset[i].IsyeriId > 30) {
                                            fad.push(veri.recordset[i].IsyeriAdi);
                                            firmagecmisi.push(veri.recordset[i].FirmaGecmisi);
                                            route.push(veri.recordset[i].router);
                                        }
                                    }


                                    str = "";
                                    for (var j = 0; j < fad.length; j++) {
                                        str += "<div class='col-md-4'><div class='card mb-4 shadow-sm'>" +
                                            "<img src='../public/mest.jpg' style='height: 310px;' alt='Mest Cafe'><title>Placeholder</title><rect width='100%' height='100%' fill='#55595c' /><text x='50%' y='50%' fill='#eceeef'" +
                                            "dy='.3em' style='color: rgb(135, 8, 8); padding-left: 25%; '><b>" + fad[j] + "</b></text>" +
                                            "<div class='card-body'><p style='font-family: Cambria;'>" + firmagecmisi[j] + "</p><div class='d-flex justify-content-between align-items-center'>" +
                                            "<div class='btn-group'><a style='color: black;' href='/anaSayfa/" + route[j] + "'><button type='button'" +
                                            "class='btn btn-sm btn-outline-primary'>Firmayı Ziyaret Et</button></a></div><small class='text-muted'>9 mins</small>" +
                                            "</div></div></div></div>";
                                        console.log(route[j])
                                    }


                                    res.render("Ana Sayfa.ejs", {
                                        data: str,
                                    });

                                });

                            });

                            break;

                        }
                        else if (veri.recordset.length - 1 === i) {

                            res.render("giris.ejs", { hata: "Kullanıcı adi veya şifre hatalı" });
                        }
                    }

                });
                // GİRİŞ YAPAN YETKİLİ İSE =>
            } else {
                req.query("SELECT * FROM Yetkili", function (err, veri) {

                    for (var i = 0; i < veri.recordset.length; i++) {
                        if (veri.recordset[i].Isim == kAdi && veri.recordset[i].Sifre == parola) {

                            yetkiliID = veri.recordset[i].IsyeriId;


                            girisYapanYetkiliID = veri.recordset[i].YetkiliId;
                            girisYapanınIsyeriID = veri.recordset[i].IsyeriId;

                            req.query("SELECT * FROM Bilgiler ", function (err, data) {
                                for (var i = 0; i < data.recordset.length; i++) {
                                    if (data.recordset[i].IsyeriId == yetkiliID) {
                                        console.log(data.recordset[i]);
                                    }
                                }
                            });

                            res.render("YetkiliSayfasi.ejs", { temp: yetkiliID });

                        } else if (veri.recordset.length - 1 === i) {

                            res.render("giris.ejs", { hata: "Kullanıcı adi veya şifre hatalı" });
                        }
                    }

                });
            }


        })
    }

    getBlog();

});


/*
- KAYIT OLMA SAYFASİ ROOTU
*/
var id4 = 0;

app.post("/yorumYap", function (req, res) {
    var yorum = req.body.i;

    var dbConfig = {
        server: "DESKTOP-4TL1V43\\SQLEXPRESS",
        database: "eRandevum",
        user: "deniz",
        password: "deniz",
        port: 1433
    }

    function getBlog() {
        var conn = new sql.ConnectionPool(dbConfig);
        var req = new sql.Request(conn);

        conn.connect(function (error) {
            if (error) {
                console.log(error);
                return;
            }
            req.query("SELECT * FROM Kullanici", function (err, veri) {
                for (var i = 0; i < veri.recordset.length; i++) {
                    if (kAdi == veri.recordset[i].Isim) {
                        id4 = veri.recordset[i].KullaniciId;
                    }
                }
                req.query("INSERT INTO SoruCevap(IsyeriId, KullaniciId, SoruMetni) VALUES('" +
                    girilenID + "' , '" + id4 + "' , '" + yorum + "')");

                res.send("<h1>MESAJINIZ YETKİLİYE GÖNDERİLDİ</h1>");

            });


        });
    }


    getBlog();



})



//kayitol html sayfasi
app.get("/kayitol", function (req, res) {
    fs.readFile("./views/kayitOl.html", function (err, data) {
        res.write(data);
        res.end();
    });
})


app.post("/kayitolma", function (req, res) {

    var ad = req.body.kAd;
    var soyad = req.body.kSoyad;
    var email = req.body.kEmail;
    var parola = req.body.parola;
    var dTarihi = req.body.dTarihi;
    var tel = req.body.kTel;
    var sehir = req.body.sehir;
    var kTuru = req.body.kturu;


    var dbConfig = {
        server: "DESKTOP-4TL1V43\\SQLEXPRESS",
        database: "eRandevum",
        user: "deniz",
        password: "deniz",
        port: 1433
    }


    function getBlog() {
        var conn = new sql.ConnectionPool(dbConfig);
        var req = new sql.Request(conn);

        conn.connect(function (error) {
            if (error) {
                console.log(error);
                return;
            }
            if (kTuru == "kullanıcı") {
                req.query("INSERT INTO Kullanici(Isim, Soyisim, Sifre, Eposta, Telefon) VALUES('" +
                    String(ad) + "' , '" + String(soyad) + "' , '" + String(parola) + "','" +
                    String(email) + "' , '" + String(tel) + "')");
                res.render("giris.ejs");
            } else {

                req.query("INSERT INTO Yetkili(Isim, Soyisim, DogumTarihi , Sifre, Telefon) VALUES('" +
                    String(ad) + "' , '" + String(soyad) + "' , '" + String(dTarihi) + "','" + String(parola) +
                    "' , '" + String(tel) + "')");

                res.render("firmaEkleme.ejs");
            }


            //  req.query("SELECT * FROM Kullanici", function (err, veri) {

            // });
        });
    }


    getBlog();


});



////////////////////////////////7




//HAKKIMIZDA
app.get("/hakkimizda", function (req, res) {
    fs.readFile("./views/hakkimizda.html", function (err, data) {
        res.write(data);
        res.end();
    });
})




//YardımDestek Safası al butonu 
app.get("/destek", function (req, res) {
    fs.readFile("./views/yardımdestek.html", function (err, data) {
        res.write(data);
        res.end();
    });
})


//////////////// VERİTABANI FİRMA VERİLERİNİ ÇEKME ///////////////

var dbConfig = {
    server: "DESKTOP-4TL1V43\\SQLEXPRESS",
    database: "eRandevum",
    user: "deniz",
    password: "deniz",
    port: 1433
}

var yetkiliTunay = 0;
var sonIsyeri = 0;

app.post("/kayitolma/firmaKayit", function (req, res) {
    var firmaAdi = req.body.fAd;
    var fGecmisi = req.body.fGecmisi;

    var rBilgisi = req.body.rBilgisi;
    var cBilgisi = req.body.cBilgisi;
    var il = req.body.il;
    var ilce = req.body.ilce;
    var sokak = req.body.sokak;
    var no = req.body.no;
    var tel = req.body.tel;
    var mail = req.body.mail;

    var harfler = firmaAdi.split(" ");
    var rout = harfler[0];
    var conn = new sql.ConnectionPool(dbConfig);
    var req = new sql.Request(conn);

    conn.connect(function (error) {
        if (error) {
            console.log(error);
            return;
        }

        req.query("SELECT * FROM Yetkili", function (err, veri) {
            for (var i = 0; i < veri.recordset.length; i++) {
                if (veri.recordset.length - 1 == i) {
                    req.query("INSERT INTO IsYeri(IsYeriAdi, YetkiliId) VALUES('" +
                        firmaAdi + "' , '" + veri.recordset[i].YetkiliId + "')");
                    yetkiliTunay = veri.recordset[i].YetkiliId;
                }
            }
            req.query("SELECT * FROM IsYeri", function (err, veri) {
                for (var i = 0; i < veri.recordset.length; i++) {
                    if (veri.recordset.length - 1 == i) {
                        var temp1 = veri.recordset[i].IsyeriId;
                        req.query("UPDATE Yetkili SET IsYeriId =" +
                            temp1 + "WHERE YetkiliId=" + yetkiliTunay);
                        sonIsyeri = veri.recordset[i].IsyeriId;
                    }
                }
                console.log("son işyeri : " + sonIsyeri);
                req.query("INSERT INTO Bilgiler(IsyeriId, IsyeriAdi, CalisanBilgi, " +
                    "FirmaGecmisi, RandevuDetayi, Il, Ilce, Sokak, No, Tel, Email, router) VALUES('" +
                    sonIsyeri + "' , '" + firmaAdi + "' , '" + cBilgisi + "' , '" + fGecmisi + "' , '" + rBilgisi + "' , '" + il + "' , '" + ilce +
                    "' , '" + sokak + "' , '" + no + "' , '" + tel + "' , '" + mail + "' , '" + rout + "')");
            });
        });







        res.render("giris.ejs");
    });


})







//Yetkili Safası al butonu 
app.get("/yetkiliAnaSayfa", function (req, res) {

    res.render("YetkiliSayfasi.ejs", { temp: girisYapanYetkiliID });

})

var toplam = 0;
var tane = 0;
var pn = 0;
var ortalama = 0;
//Yetkili puan sayfası
app.get("/puan", function (req, res) {
    var conn = new sql.ConnectionPool(dbConfig);
    var req = new sql.Request(conn);

    conn.connect(function (error) {
        if (error) {
            console.log(error);
            return;
        }
        ortalama = 0;
        tane = 0;
        req.query("SELECT * FROM Puan WHERE IsyeriId = " + girisYapanınIsyeriID, function (err, veri) {
            for (var i = 0; i < veri.recordset.length; i++) {
                if (veri.recordset[i].IsyeriId == girisYapanınIsyeriID) {
                    tane++;
                    toplam = Number(veri.recordset[i].puan);
                }
            }
            ortalama = 0;
            ortalama = Number(toplam) / Number(tane);
            res.render("isyeriPunai.ejs", {
                puan: ortalama
            });
        });
    });

})


app.post("/puanver", function (req, res) {

    var puan = req.body.iPuan;

    var conn = new sql.ConnectionPool(dbConfig);
    var req = new sql.Request(conn);

    conn.connect(function (error) {
        if (error) {
            console.log(error);
            return;
        }

        req.query("INSERT INTO Puan(IsyeriId, puan) VALUES('" +
            girilenID + "' , '" + puan + "')");
        res.send("<h1 style='padding-left: 30%; padding-top:20%'>Puanınız İşleme Alınmıştır.</h1>");


    });
})


//firmabilgileri sayfasi sayfası
app.get("/firmaBilgileri", function (req, res) {
    function veriGetir() {
        var conn = new sql.ConnectionPool(dbConfig);
        var req = new sql.Request(conn);

        conn.connect(function (error) {
            if (error) {
                console.log(error);
                return;
            }

            req.query("SELECT * FROM Bilgiler", function (err, veri) {
                for (var i = 0; i < veri.recordset.length; i++) {
                    if (veri.recordset[i].IsyeriId == yetkiliID) {

                        res.render("firmaBilgiler.ejs", {
                            firmaIsmi: veri.recordset[i].IsyeriAdi,
                            calisan: veri.recordset[i].CalisanBilgi,
                            firmaTarihi: veri.recordset[i].FirmaGecmisi,
                            //randevuDetayi,
                            il: veri.recordset[i].Il,
                            ilce: veri.recordset[i].Ilce,
                            sokak: veri.recordset[i].Sokak,
                            no: veri.recordset[i].No,
                            tel: veri.recordset[i].Tel,
                            mail: veri.recordset[i].Email,
                        });


                        //     isyeriAdi = veri.recordset[i].IsyeriAdi;

                    }
                }
            });


        });
    }
    veriGetir();


})

var id3 = [];
var sorumetni = [];
var counter2 = 0;
var str = "";

//yetkili yorrum sayfası
app.get("/yorum", function (req, res) {
    function veriGetir() {
        var conn = new sql.ConnectionPool(dbConfig);
        var req = new sql.Request(conn);

        conn.connect(function (error) {
            if (error) {
                console.log(error);
                return;
            }
            id3 = [];
            sorumetni = [];

            req.query("SELECT * FROM SoruCevap where IsyeriId=" + girisYapanınIsyeriID, function (err, veri) {
                for (var i = 0; i < veri.recordset.length; i++) {
                    id3.push(veri.recordset[i].KullaniciId);
                    sorumetni.push(veri.recordset[i].SoruMetni);
                }


                str = "";
                for (var j = 0; j < id3.length; j++) {
                    str += "<div class='media text-muted pt-3'><svg class='bd-placeholder-img mr-2 rounded' width='32' height='32'" +
                        "xmlns='http://www.w3.org/2000/svg' preserveAspectRatio='xMidYMid slice' focusable='false' role='img'" +
                        "aria-label='Placeholder: 32x32'><title>Placeholder</title><rect width='100%' height='100%' fill='#007bff' />" +
                        "<text x='50%' y='50%' fill='#007bff'dy='.3em'>32x32</text></svg><div class='media-body pb-3 mb-0 small lh-125 border-bottom border-gray'>" +
                        "<div class='d-flex justify-content-between align-items-center w-100'><strongclass='text-gray-dark'>" + id3[j] + "</strong><br>" + sorumetni[j] +
                        "<form action='/aa'><input type='text' placeholder='Cevap yazın' style = 'padding: 5px;'><br><input type='submit' value='GÖNDER' class='btn btn-primary' style='width: 120px;'>" +
                        "</div><span class='d-block'></span>" +
                        "</form></div></div>";
                }


                res.render("yorum.ejs", {
                    data1: str,
                });

            });

        });
    }

    veriGetir();

});


var counter = 0;

var rndv1 = [];
var trh1 = [];
var saat1 = [];




var str2 = "";
//yetkili yorrum sayfası
app.get("/randevular", function (req, res) {
    function veriGetir() {
        var conn = new sql.ConnectionPool(dbConfig);
        var req = new sql.Request(conn);

        conn.connect(function (error) {
            if (error) {
                console.log(error);
                return;
            }
            rndv1 = [];
            saat1 = [];
            trh1 = [];

            req.query("SELECT * FROM Randevu", function (err, veri) {
                for (var i = 0; i < veri.recordset.length; i++) {
                    if (veri.recordset[i].IsyeriId === yetkiliID) {

                        rndv1.push(veri.recordset[i].KullaniciId);
                        trh1.push(veri.recordset[i].RandevuTarih);
                        saat1.push(veri.recordset[i].RandevuSaat);
                    }
                }


                str2 = "";
                for (var j = 0; j < rndv1.length; j++) {
                    str2 += "<div class='media text-muted pt-3'><svg class='bd-placeholder-img mr-2 rounded' width='32' height='32' " +
                        "xmlns='http://www.w3.org/2000/svg' preserveAspectRatio='xMidYMid slice' focusable='false' role='img' aria-label='Placeholder: 32x32'>" +
                        "<title>Placeholder</title><rect width='100%' height='100%' fill='#6f42c1' /><text x='50%' y='50%' fill='#6f42c1'" +
                        "dy='.3em'>32x32</text></svg><p class='media-body pb-3 mb-0 small lh-125 border-bottom border-gray'>" +
                        rndv1[j] + "<strong class='d-block text-gray-dark'></strong>tarih : " + trh1[j] + " saat : " + saat1[j] + "</p></div>"

                }

                res.render("randevular.ejs", {
                    data: str2,
                });
            });

        });
    }

    veriGetir();

})



var server = app.listen(8080, function () {
    console.log("server created...");
});