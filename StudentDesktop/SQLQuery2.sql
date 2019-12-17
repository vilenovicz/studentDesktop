--select Id, Code, Name  from Competences
exec uspNewCompetence 2,2

exec uspNewPerson "Семенов","Семен", "02.12.2019 14:55", 1

--select * from person_competence order by 2

--delete from person_competence where id in (13)

select * from courses


select cp.CourseId, p.LastName, p.FirstName from Persons p inner join course_person cp on p.id = cp.CourseId

select cr.id as id, 
                cr.Name as [Название курса], 
                c.Name as [Компетенция],
                cr.DateFrom [Дата начала],
                cr.DateTo [Дата окончания]
                from courses cr inner join Competences c on cr.competenceId = c.id


select pc.PersonId, c.Code, c.Name  from Competences c inner join person_competence pc on c.id = pc.CompetenceId

select * from Courses c
inner join course_person cp on c.Id = cp.courseId
inner join Persons p on cp.PersonId = p.Id

delete from courses where id = 2
delete from course_person where courseId = 2

select * from persons
select * from person_competence where personid in (4,5)
delete from persons where id = 5

exec uspDeletePerson 5