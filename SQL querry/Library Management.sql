select * from staff


insert into [dbo].[Staff] values('arvind', 'admin1', 'admin123', 'aksahub088@gmail.com', 9325860577)

create table Book
(
	BookCode int not null primary key,
	BookName varchar(30) not null,
	Author varchar(20),
	Issuable bit not null default(0),
	Isissued bit not null default(0)
)


select * from Book

create table MemberType
(
	MemberTypeID int not null primary key,
	MemberType varchar(20) not null,
	BooksAllowed int not null,
	DaysAllowed int not null
)

insert into MemberType values(1001, 'employee', 25, 90)
insert into MemberType values(1002, 'student', 3, 25)


create table IssueBook
(
	
)

create table Member
(
	MemberCode int not null primary key identity(1,2),
	MemberName varchar(30) not null,
	MemberTypeID int not null,
	NoOfBookIssued int not null default(0),
	foreign key (MemberTypeID) References MemberType(MemberTypeID)
)
select * from Member

drop table IssueBook
create table IssueBook
(
	issueCode int Identity(1,1) not null,
	MemberCode int not null,
	BookCode int not null,
	IssueDate Date not null,
	DueDate date ,
	ActualReturnDate date,
	primary key (issueCode),
	foreign key (MemberCode) references Member(MemberCode),
	foreign key (BookCode) references Book(BookCode)
)

select * from IssueBook



insert into member values('student1', 1001, 0)
insert into member values('student2', 1001, 0)
insert into member values('student3', 1001, 0)
insert into member values('student4', 1001, 0)


insert into book values(10000, 'PHP', 'xyz', 1, 0)
insert into book values(10001, 'C++', 'abc', 1, 0)
insert into book values(10002, 'Java', 'mnk', 1, 0)
insert into book values(10003, 'c#', 'ms', 1, 0)
insert into book values(10004, 'OS', 'Richard', 1, 0)
insert into book values(10005, 'Ds', 'Riche', 1, 0)










select * from Book
select * from Member
select * from MemberType
select * from IssueBook

insert into Book values(1006, 'theory of computation', 'RBR', 1, 0)

insert into Book values(1007,'Automata theory', 'OG Kakde', 1, 0)
insert into Book values(1008, 'Computer Network', 'Richa Makjhhani', 1, 0)
insert into Book values(1009, 'DBMA', 'Jitendra Tembhurane', 1, 0)

insert into Member values( 'Richa Makjhhani', 1003, 0)
insert into Member values( 'Jitendra tembhurane', 1003, 0)
insert into Member values( 'O G Kakde', 1003, 0)
insert into Member values( 'Vipin Kamble', 1003, 0)
insert into Member values( 'Pooja Jain', 1003, 0)

insert into MemberType values(1003, 'Facuilty', 25, 90)

insert into IssueBook values(

select * from Member
select * from Book
select * from IssueBook

sp_help IssueBook



insert into IssueBook values(1, 1006, '2021/01/01', '2021/01/01', '2021/01/01')
insert into IssueBook values(2003, 1007, '2021/06/17', '2021/06/24', '2021/06/23')
insert into IssueBook values(5, 1009, '2021/06/01', '2021/06/25', '2021/06/24')
insert into IssueBook values(7, 1008, '2021/03/01', '2021/06/20', '2021/06/01')

select * from IssueBook
select * from Book
Select * from Member
select * from MemberType

select ib.issueCode, b.BookName, b.Author, ib.IssueDate, ib.DueDate, ib.ActualReturnDate from Book as b, IssueBook as ib, Member as m where m.MemberCode=ib.MemberCode and b.BookCode=ib.BookCode and m.MemberCode=1

select * from sys.tables




