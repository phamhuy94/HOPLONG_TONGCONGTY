﻿app.service('giamdocService', function ($http) {
    this.get_giamdoc = function (username) {
        return $http.get("/api/Api_GiamDocChiNhanh/" + username).then(function (response) {
            return response.data;
        });
    }
});

app.service('hanghoaService', function ($http) {
    this.get_hanghoa = function () {
        return $http.get("/api/Api_HanghoaHL").then(function (response) {
            return response.data;
        });
    }
    this.get_nhomhang = function () {
        return $http.get("/api/Api_NhomVTHHHL").then(function (response) {
            return response.data;
        });
    }
    this.add = function (data_add) {
        return $http.post("/api/Api_HanghoaHL", data_add);
    };

    this.save = function (mahang, data_update) {
        return $http.put("/api/Api_HanghoaHL/" + mahang, data_update);
    }

    this.delete = function (mahang, data_delete) {
        return $http.delete("/api/Api_HanghoaHL/" + mahang, data_delete);
    }
    this.get_hangtonkho = function (id) {
        return $http.get("/api/Api_TonkhoHL/" + id).then(function (response) {
            return response.data;
        });
    };
});



app.service('NhomvthhService', function ($http) {
    this.get_hangsp = function () {
        return $http.get("/api/Api_NhomVTHHHL").then(function (response) {
            return response.data;
        });
    }
    this.add = function (data_add) {
        return $http.post("/api/Api_NhomVTHHHL/", data_add);
    };

    this.save = function (hangsp, data_update) {
        return $http.put("/api/Api_NhomVTHHHL/" + hangsp, data_update);
    }

    this.delete = function (hangsp, data_delete) {
        return $http.delete("/api/Api_NhomVTHHHL/" + hangsp, data_delete);
    }
    
});


app.service('khoService', function ($http) {
    this.get_kho = function () {
        return $http.get("/api/Api_KhoHL").then(function (response) {
            return response.data;
        });
    };
    this.add = function (data_add) {
        return $http.post("/api/Api_KhoHL", data_add);
    };

    this.save = function (makho, data_update) {
        return $http.put("/api/Api_KhoHL/" + makho, data_update);
    };

    this.delete = function (makho, data_delete) {
        return $http.delete("/api/Api_KhoHL/" + makho, data_delete);
    };
});

app.service('userService', function ($http) {
    this.get_user = function () {
        return $http.get("/api/Api_NguoidungHL").then(function (response) {
            return response.data;
        });
    };
    this.add = function (data_add) {
        return $http.post("/api/Api_NguoidungHL", data_add);
    };
    this.add_nhanvien = function (nhanvien_add) {
        return $http.post("/api/Api_NhanvienHL", nhanvien_add);
    };

    this.save = function (username, data_update) {
        return $http.put("/api/Api_NguoidungHL/" + username, data_update);
    };

    this.save_nhanvien = function (username, nhanvien_update) {
        return $http.put("/api/Api_NhanvienHL/" + username, nhanvien_update);
    };
});

app.service('nhanvienService', function ($http) {
    this.get_nhanvien = function (username) {
        return $http.get("/api/Api_NhanvienHL/" + username).then(function (response) {
            return response.data;
        });
    };
});

app.service('phongbanService', function ($http) {
    this.get_phongban = function () {
        return $http.get("/api/Api_PhongbanHL").then(function (response) {
            return response.data;
        });
    };
    this.save = function (maphongban, data_update) {
        return $http.put("/api/Api_PhongbanHL/" + maphongban, data_update);
    };

    this.delete = function (maphongban, data_delete) {
        return $http.delete("/api/Api_PhongbanHL/" + maphongban, data_delete);
    };
});

app.service('nhanvienphongbanService', function ($http) {
    this.get_nhanvien = function (maphongban) {
        return $http.get("/api/Api_NhanvienphongbanHL/" + maphongban).then(function (response) {
            return response.data;
        });
    };
});

app.service('taikhoanService', function ($http) {
    this.get_taikhoan = function () {
        return $http.get("/api/Api_TaiKhoanHachToan").then(function (response) {
            return response.data;
        });
    };
    this.add = function (data_add) {
        return $http.post("/api/Api_TaiKhoanHachToan", data_add);
    };

    this.save = function (sotk, data_update) {
        return $http.put("/api/Api_TaiKhoanHachToan/" + sotk, data_update);
    }

    this.delete = function (sotk, data_delete) {
        return $http.delete("/api/Api_TaiKhoanHachToan/" + sotk, data_delete);
    }
});