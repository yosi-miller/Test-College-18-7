CREATE DATABASE college

-- ���� ����������
CREATE TABLE leads(
	id INT PRIMARY KEY IDENTITY,
	leads_name VARCHAR(20),
	city VARCHAR(20),
	phone VARCHAR(10)
	)

INSERT INTO leads (leads_name, city, phone)
VALUES ('avi', 'bnay brak', '0500500555')

SELECT * FROM leads

-- ���� �����
CREATE TABLE lecturer(
	id INT PRIMARY KEY IDENTITY,
	lecturer_name VARCHAR(20),
	hourly_rate int
	)

INSERT INTO lecturer (lecturer_name, hourly_rate)
VALUES ('ahron', 55)

SELECT * FROM lecturer

-- ���� ����� ����
CREATE TABLE topics(
	id INT PRIMARY KEY IDENTITY,
	topic VARCHAR(20),
	lecturer_id INT FOREIGN KEY REFERENCES lecturer(id),
	course_hours INT
	)

INSERT INTO topics (topic, lecturer_id, course_hours)
VALUES ('vue', 1, 40)

INSERT INTO topics (topic, lecturer_id, course_hours)
VALUES ('react', 1, 55)

SELECT * FROM topics
SELECT topic FROM topics

-- ���� ������ ������
CREATE TABLE courses(
	id INT PRIMARY KEY IDENTITY,
	time VARCHAR(20),
	days VARCHAR(20),
	type VARCHAR(20),
	price INT,
	date_open DATE
	)

INSERT INTO courses (time, days, type, price, date_open)
VALUES ('17:00 - 21:00', 'a - d - c', '����������', 5000, '20240718')

-- ����� ���� ������ ��� ������ �������
CREATE TABLE topic_of_course(
	id INT PRIMARY KEY IDENTITY,
	topic_id INT FOREIGN KEY REFERENCES topics(id),
	course_id INT FOREIGN KEY REFERENCES courses(id)
	)

INSERT INTO topic_of_course(topic_id, course_id)
VALUES (1, 1)

INSERT INTO topic_of_course(topic_id, course_id)
VALUES (2, 2)

INSERT INTO topic_of_course(topic_id, course_id)
VALUES (2, 1)

INSERT INTO topic_of_course(topic_id, course_id)
VALUES (1, 2)


SELECT topic FROM topics
SELECT type, id FROM courses
SELECT * FROM topic_of_course

-- ������ ������� ��� ���� �� ������� ��� �� ����� ������ ������ ���� ����� ��� ���� ���� ������ ����
SELECT courses.type, topics.topic
FROM courses
INNER JOIN topic_of_course
ON courses.id = topic_of_course.course_id
INNER JOIN topics
ON topics.id = topic_of_course.topic_id
ORDER BY courses.type

-- ���� ��������
CREATE TABLE student(
	id INT PRIMARY KEY IDENTITY,
	student_name VARCHAR(20),
	city VARCHAR(20),
	phone VARCHAR(10)
	)

INSERT INTO student (student_name, city, phone)
VALUES ('MOSI', 'HIAFA', '18004040')
INSERT INTO student (student_name, city, phone)
VALUES ('YOSI', 'b-b', '180004242')

SELECT * FROM student

-- ����� ���� ������ ��� ������ �������
CREATE TABLE student_of_course(
	id INT PRIMARY KEY IDENTITY,
	student_id INT FOREIGN KEY REFERENCES student(id),
	course_id INT FOREIGN KEY REFERENCES courses(id),
	)

INSERT INTO student_of_course(student_id, course_id)
VALUES (2, 2)

INSERT INTO student_of_course(student_id, course_id)
VALUES (2, 1)

INSERT INTO student_of_course(student_id, course_id)
VALUES (2, 1)

INSERT INTO student_of_course(student_id, course_id)
VALUES (1, 1)

INSERT INTO student_of_course(student_id, course_id)
VALUES (1, 2)

-- ���� ����� ��� ������ ������� ��� �� ���� ��� ������
INSERT INTO student_of_course(student_id, course_id)
VALUES ((SELECT id FROM student WHERE student_name = 'YOSI'),
		(SELECT id FROM courses WHERE type = '����������'))

SELECT * FROM student_of_course
SELECT * FROM student
SELECT price, id FROM courses

-- ����� ������� �� ���� ������� ������ ���� - ��� �� ���� ����
SELECT SUM(courses.price)
FROM courses
INNER JOIN student_of_course
ON student_of_course.course_id = courses.id
WHERE student_of_course.student_id = (SELECT id FROM student WHERE student_name = 'YOSI')

-- ���� ����� �� �������� ������ ����
CREATE TABLE pay(
	id INT PRIMARY KEY IDENTITY,
	student_id INT FOREIGN KEY REFERENCES student(id),
	payment INT
	)

INSERT INTO pay (student_id, payment)
VALUES ((SELECT id FROM student WHERE student_name = 'ahron'),
		2500)

INSERT INTO pay (student_id, payment)
VALUES ((SELECT id FROM student WHERE student_name = 'ahron'),
		500)

INSERT INTO pay (student_id, payment)
VALUES ((SELECT id FROM student WHERE student_name = 'YOSI'),
		500)

INSERT INTO pay (student_id, payment)
VALUES ((SELECT id FROM student WHERE student_name = 'YOSI'),
		1500)

SELECT * FROM pay

-- ����� �� ���� ������� ����, ����� ���� ��� ���� ���� �� ���� ���� �������
SELECT SUM(pay.payment)
FROM pay
INNER JOIN student
ON pay.student_id = student.id
WHERE pay.student_id = (SELECT id FROM student WHERE student_name = 'YOSI')