import { useEffect, useState } from "react";
import "./delete.css";

const API_URL = "http://localhost:5264/api/students";

function DeleteStudent() {
  const [students, setStudents] = useState([]);
  const [loading, setLoading] = useState(true);
  const [deletingRollNumber, setDeletingRollNumber] = useState(null);
  const [status, setStatus] = useState("");

  useEffect(() => {
    let active = true;

    fetch(API_URL)
      .then((response) => {
        if (!response.ok) throw new Error(`Request failed (${response.status})`);
        return response.json();
      })
      .then((data) => {
        if (active) setStudents(data);
      })
      .catch((error) => {
        if (active) setStatus(error.message || "Could not load students.");
      })
      .finally(() => {
        if (active) setLoading(false);
      });

    return () => {
      active = false;
    };
  }, []);

  async function handleDelete(rollNumber) {
    setDeletingRollNumber(rollNumber);
    setStatus("");

    try {
      const response = await fetch(`${API_URL}/${rollNumber}`, { method: "DELETE" });
      if (!response.ok) throw new Error(`Delete failed (${response.status})`);

      setStudents((currentStudents) =>
        currentStudents.filter((student) => student.rollNumber !== rollNumber),
      );
      setStatus("Student deleted.");
    } catch (error) {
      setStatus(error.message || "Could not delete student.");
    } finally {
      setDeletingRollNumber(null);
    }
  }

  return (
    <main className="delete-page">
      <h1>Delete Student</h1>
      <p role="status" aria-live="polite">{status}</p>
      {loading ? (
        <p>Loading students...</p>
      ) : students.length === 0 ? (
        <p>No students to delete.</p>
      ) : (
        <table>
          <thead>
            <tr>
              <th>Roll Number</th>
              <th>Name</th>
              <th>Class</th>
              <th>Action</th>
            </tr>
          </thead>
          <tbody>
            {students.map((student) => (
              <tr key={student.rollNumber}>
                <td>{student.rollNumber}</td>
                <td>{student.studentName}</td>
                <td>{student.studentClass}</td>
                <td>
                  <button
                    className="deletestudent"
                    type="button"
                    disabled={deletingRollNumber !== null}
                    onClick={() => {
                      if (!window.confirm("Are you sure you want to delete this student?")) {
                        return;
                      }
                      handleDelete(student.rollNumber);
                    }}
                  >
                    {deletingRollNumber === student.rollNumber ? "Deleting..." : "Delete"}
                  </button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </main>
  );
}

export default DeleteStudent;