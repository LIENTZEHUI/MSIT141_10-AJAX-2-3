var emp = {
    employees: [
        { name: "Tom", workYears: 3, salary: 35000 },
        { name: "Jack", workYears: 5, salary: 40000 },
        { name: "Mary", workYears: 7, salary: 45000 },
    ],
};

function myFunction() {
    document.write("<table style='border: 3px solid #558c5b'>");
    for (let i = 0, max = emp.employees.length; i < max; i++) {
        document.write("<tr style='border: 1px solid #3f358c'>");
        document.write("<td style='border: 1px solid #3f358c'>");
        document.write(emp.employees[i].name);
        document.write("<td style='border: 1px solid #3f358c'>");
        document.write(emp.employees[i].workYears);
        document.write("<td style='border: 1px solid #3f358c'>");
        document.write(emp.employees[i].salary);
        document.write("</td>");
    }
}
