CREATE TABLE info(
	fullname nvarchar(20) NOT NULL,
	type nvarchar(20) NOT NULL,
	id nvarchar(20) NOT NULL primary key,
	password nvarchar(20) NOT NULL,
	dob date NOT NULL,
	age int NOT NULL,
	gender nvarchar(20) NOT NULL,
	address nvarchar(20) NOT NULL,
)

CREATE TABLE petinfo(
	petid nvarchar(20) NOT NULL primary key,
	pettype nvarchar(20) NOT NULL,
	petage nvarchar(20) NOT NULL,
	weight nvarchar(20) NOT NULL,
	color nvarchar(20) NOT NULL,
	petcatagory nvarchar(50) NOT NULL,
)

CREATE TABLE requestinfo(
	userid nvarchar(20) NOT NULL,
	pid nvarchar(20) NULL,
	ptype nvarchar(20) NOT NULL,
	catagory nvarchar(20) NOT NULL,
	fosterdays nvarchar(20) NULL,
	)

INSERT info (fullname, type, id, password, dob, age, gender, address) VALUES (N'Jannat', N'user', N'U-003', N'1234', CAST(N'1999-02-06' AS Date), 22, N'female', N'Dhaka')
INSERT info (fullname, type, id, password, dob, age, gender, address) VALUES (N'Mubin', N'admin', N'U-004', N'12345', CAST(N'1990-02-03' AS Date), 23, N'male', N'USA')
INSERT info (fullname, type, id, password, dob, age, gender, address) VALUES (N'Jahin', N'user', N'A-005', N'121', CAST(N'2022-01-09' AS Date), 90, N'female', N'UK')


INSERT petinfo (petid, pettype, petage, weight, color, petcatagory) VALUES (N'P-001', N'cat', N'5months', N'1.5kg', N'brown', N'adoption')
INSERT petinfo (petid, pettype, petage, weight, color, petcatagory) VALUES (N'P-002', N'cat', N'8months', N'2kg', N'white-black', N'foster')
INSERT petinfo (petid, pettype, petage, weight, color, petcatagory) VALUES (N'P-003', N'rabbit', N'3 weeks', N'600gm', N'white', N'adoption')
INSERT petinfo (petid, pettype, petage, weight, color, petcatagory) VALUES (N'P-004', N'rabbit', N'7 weeks', N'700gm', N'brown', N'adoption')
INSERT petinfo (petid, pettype, petage, weight, color, petcatagory) VALUES (N'P-005', N'dog', N'5 months', N'3kg', N'brown', N'foster')
INSERT requestinfo (userid, pid, ptype, catagory, fosterdays) VALUES (N'U-001', N'P-001', N'cat', N'adoption', N'15 days')


