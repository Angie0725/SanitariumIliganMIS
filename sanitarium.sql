create database sanita

connect to sanita

create table suppliers (supplier_number int not null primary key generated always as identity (start with 1 increment by 1), supplier_name varchar(100), address varchar(250), telnumber varchar(20), fax_number varchar(20))

create table supplies (item_number int not null primary key generated always as identity (start with 1 increment by 1), supplier_number int, item_name varchar(100), description varchar(250), quantity_in_stock int, reorder_level int, cost_per_unit decimal(4,4), type varchar(100))

create table pharmasupplies (drug_number int not null primary key generated always as identity (start with 1 increment by 1), supplier_number int, drug_name varchar(100), description varchar(250), dosage varchar(100), method_of_administration varchar(300), quantity_in_stock int, reorder_level int, cost_per_unit decimal(4,4))

create table requisition (drug_number int not null primary key generated always as identity (start with 1 increment by 1), supplier_number int, drug_name varchar(100), description varchar(250), dosage varchar(100),method_of_administration varchar(300), quantity_in_stock int, reorder_level int, cost_per_unit decimal(4,4))

create table medications (medication_id int not null primary key generated always as identity (start with 1 increment by 1), in_patient_id int, drug_number int, units_per_day int , startdate date, finishdate date)

create table inpatients (in_patient_id int not null primary key generated always as identity (start with 1 increment by 1), patient_number int, date_arrived timestamp, bednumber varchar(5), expected_duration varchar(200), date_placed_in_ward date, date_expected_to_leave date, date_left date)

create table patients (patient_number int not null primary key generated always as identity (start with 1 increment by 1), firstname varchar(100), lastname varchar(100), address varchar(200), telnumber varchar(20), birthdate date, sex varchar(7), marital_status varchar(50), date_registered date)

create table patientkins (PKID int not null primary key generated always as identity (start with 1 increment by 1), patient_number int, next_of_kin_id int, relationship_to_patient varchar(200))

create table patientdoctors (PDID int not null primary key generated always as identity (start with 1 increment by 1), patient_number int, doctor_id int, date_assigned date)

create table nextofkin (next_of_kin_id int not null primary key generated always as identity (start with 1 increment by 1), firstname varchar(100), lastname varchar(100), address varchar(200), telnumber varchar(20))

create table outsidedoctors (doctor_id int not null primary key generated always as identity (start with 1 increment by 1), firstname varchar(100), lastname varchar(100), clinic_number int, address varchar(200), telnumber varchar(20))

create table outpatient (out_patient_id int not null primary key generated always as identity (start with 1 increment by 1), patient_number int, appointment_number int)

create table beds (bed_number int not null primary key generated always as identity (start with 1 increment by 1), ward_number int, availability varchar(20))

create table wardnames (ward_name_id int not null primary key generated always as identity (start with 1 increment by 1), ward_name int, description varchar(200))

create table clinic (clinic_number int not null primary key generated always as identity (start with 1 increment by 1), description varchar(200))

create table clinicwardstaff (CSID int not null primary key generated always as identity (start with 1 increment by 1), clinic_ward_number int, staff_number int, date_assigned date, shift varchar(20))

create table wards (ward_number int not null primary key generated always as identity (start with 1 increment by 1), wardname_id int, location varchar(200), total_num_beds int, tel_phone_ext varchar(20))

create table appointments (appointment_number int not null primary key generated always as identity (start with 1 increment by 1), patient_number int, staff_number int, appointmemt_date date, appointment_time time,  examination_room varchar(200))

create table staff (staff_number varchar(20), firstname varchar(100), lastname varchar(100), address varchar(200), telnumber varchar(20),birthdate date, sex varchar(7), NIN varchar(200), position_held_id int, type_of_employment varchar(50), num_hours_worked int, salary_payment_type varchar(100))

create table positionheld (position_held_id int not null primary key generated always as identity (start with 1 increment by 1), positionid int, staff_number int, start_date date, type_of_employment varchar(100), num_hours_worked decimal(4,4), salary_payment_type varchar(80))

create table position (position_id int not null primary key generated always as identity (start with 1 increment by 1), position_title varchar(100), salary_scale int)

create table salary (salary_scale int not null primary key generated always as identity (start with 1 increment by 1), salary decimal(7,4), description varchar(200))

create table qualifications (qualification_id int not null primary key generated always as identity (start with 1 increment by 1), staff_number int, qualification_description varchar(200))

create table workexperience (work_experience_id int not null primary key generated always as identity (start with 1 increment by 1), staff_number int, position varchar(200), organzation_name varchar(200), start_date date,finish_date date)
