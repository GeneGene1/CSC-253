CREATE TABLE [dbo].[Employee] (
    [employee_ID]     INT        IDENTITY (1, 1) NOT NULL,
    [name]            NCHAR (50) NOT NULL,
    [position]        NCHAR (50) NOT NULL,
    [hourly_pay_rate] NCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([employee_ID] ASC)
);

