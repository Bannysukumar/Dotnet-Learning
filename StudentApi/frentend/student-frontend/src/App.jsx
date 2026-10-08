import { useEffect, useState } from "react";

const API_URL = "http://localhost:5264/api/students";

function App() {
  const [students, setStudents] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    let active = true;

    fetch(API_URL)
      .then((response) => response.json())
      .then((data) => {
        if (active) setStudents(data);
      })
      .catch((error) => {
        if (active) console.error("Error fetching students:", error);
      })
      .finally(() => {
        if (active) setLoading(false);
      });

    return () => {
      active = false;
    };
  }, []);
  return (
    <div className="App">
      <h1>Student List</h1>
      {loading ? (
        <p>Loading...</p>
      ) : (
        <table>
          <thead>
            <tr>
              <th>Name</th>
              <th>Class</th>
              <th>Email</th>
              <th>Phone</th>
              <th>Age</th>
            </tr>
          </thead>
          <tbody>
            {students.map((student) => (
              <tr key={student.rollNumber}>
                <td>{student.studentName}</td>
                <td>{student.studentClass}</td>
                <td>{student.email}</td>
                <td>{student.phoneNumber}</td>
                <td>{student.age}</td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
  
}
export default App;