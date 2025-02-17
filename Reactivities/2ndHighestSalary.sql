--Find users who have a salary less than 1000 or have no salary yet.

select u.name from [User] u left join [Salary] s on u.user_id=s.user_id where s.salary <1000 or s.salary is null

--Find users who have the third highest salary.
select * from  salary
 
select top(1)* from 
(select distinct top(4) s.salary ,u.name from [User] u left join salary s on u.user_id=s.user_id  
order by s.salary desc)  result 
order by salary asc

--Using Danserank

select * from (
select u.name,s.salary, Dense_rank() over ( order by salary desc) as salary_Rank from [User] u join Salary s 
on u.user_id=s.user_id) ranked 
where salary_Rank=3
 
 --row_number create sequenceial number to each row.
 select user_id, salary, row_number() over(order by salary desc) from Salary order by salary desc
   

  
  