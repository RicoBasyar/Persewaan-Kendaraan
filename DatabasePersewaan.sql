create database persewaanREF
use persewaanREF

create table admin	(	id_admin varchar(18) PRIMARY KEY not null,
						nama_admin varchar(21) not null,
						password varchar (18) not null)

create table kendaraan ( no_pol varchar(10) PRIMARY KEY not null,
						 no_mesin numeric not null,
						 no_rangka varchar(10) not null,
						 jenis_kendaraan varchar(5) CHECK(jenis_kendaraan = 'Mobil' OR 
						 jenis_kendaraan = 'Motor') not null,
						 merk_kendaraan varchar(10) not null,
						 harga_perhari numeric,
						 id_admin varchar(18) FOREIGN KEY references admin(id_admin))

create table customer (	nik varchar(20) PRIMARY KEY not null,
						nama_customer varchar(21) not null,
						no_telp varchar(16) null,
						alamat varchar(50) not null,
						id_admin varchar(18) FOREIGN KEY references admin(id_admin))

create table transaksi (id_transaksi varchar(10) PRIMARY KEY not null,				
						id_admin varchar(18) FOREIGN KEY references admin(id_admin),
						no_pol varchar(10) FOREIGN KEY references kendaraan(no_pol) On delete CASCADE On Update Cascade,
						tgl_ambil datetime not null,
						tgl_kembali datetime not null,
						nik varchar(20) FOREIGN KEY references 	customer(nik) ON delete Cascade On Update Cascade)

Select MAX (RIGHT(id_transaksi, 2)) FROM transaksi
select * from admin
select * from kendaraan
select * from customer 
insert into admin values('A002', 'admoon', 'admoon')
insert into kendaraan values ('B 4 COD',5456454, '45454a45', 'Mobil', 'Toyota', 213213, 'A001')
delete from kendaraan where no_pol = 111222
select * from transaksi
insert into transaksi values ('TR-002', 'A001', 'B 4 COD', '2020/01/10', '2020/01/15', 111);


select customer.nama_customer, kendaraan.jenis_kendaraan, kendaraan.merk_kendaraan, kendaraan.harga_perhari
from transaksi join customer on transaksi.nik = customer.nik
join kendaraan on transaksi.no_pol = kendaraan.no_pol

select DATEDIFF(Day, tgl_ambil, tgl_kembali) AS Selisih from transaksi ---Nota---

SELECT transaksi.id_transaksi, kendaraan.jenis_kendaraan , 
FORMAT(transaksi.tgl_ambil, 'dd/MM/yyyy') as tgl_ambil, FORMAT(transaksi.tgl_kembali, 'dd/MM/yyyy') as tgl_kembali , 
DATEDIFF(DAY, transaksi.tgl_ambil, transaksi.tgl_kembali) AS [Selisih], kendaraan.harga_perhari,
DATEDIFF(DAY, transaksi.tgl_ambil, transaksi.tgl_kembali) * kendaraan.harga_perhari AS Total 
from transaksi JOIN kendaraan on transaksi.no_pol = kendaraan.no_pol
JOIN customer on transaksi.nik = customer.nik
where transaksi.id_transaksi = 'TR-004'  ---YANG INI---

SELECT FORMAT (getdate(), 'dd/MM/yyyy ') as date


