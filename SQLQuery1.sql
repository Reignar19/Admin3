CREATE DATABASE TrimTime;
USE TrimTime;

CREATE TABLE SERVICES
(
ServiceID INT PRIMARY KEY,
ServiceName VARCHAR(50) NOT NULL,
ServicePrice DECIMAL(10, 2) NOT NULL,
);

Insert INTO SERVICES (ServiceID, ServiceName, ServicePrice)
		VALUES
							(1, 'Haircut', 20.00),
							(2, 'Shave', 15.00),
							(3, 'Facial', 30.00),
							(4, 'Manicure', 25.00),
							(5, 'Pedicure', 35.00);	
SELECT * FROM SERVICES;

CREATE TABLE BOOKING(
BookingID INT PRIMARY KEY,
CustomerName VARCHAR(50) NOT NULL,
ServiceID INT NOT NULL,
BookingDate DATE NOT NULL,
BookingTime TIME NOT NULL,
);

INSERT INTO BOOKING (BookingID, CustomerName, ServiceID, BookingDate, BookingTime)
											VALUES
							(1, 'John Doe', 1, '2023-10-01', '10:00:00'),
							(2, 'Jane Smith', 2, '2023-10-02', '11:00:00'),
							(3, 'Alice Johnson', 3, '2023-10-03', '12:00:00'),
							(4, 'Bob Brown', 4, '2023-10-04', '13:00:00'),
							(5, 'Charlie Davis', 5, '2023-10-05', '14:00:00');

CREATE TABLE COMPLETEDBOOKING(
BookingID INT PRIMARY KEY,
CustomerName VARCHAR(50) NOT NULL,
ServiceID INT NOT NULL,
BookingDate DATE NOT NULL,
BookingTime TIME NOT NULL,
);