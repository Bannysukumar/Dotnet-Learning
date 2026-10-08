import { useState } from "react";
import "./addstudent.css";

const initialStudent = {
    studentName: "",
    studentClass: "",
    email: "",
    phoneNumber: "",
    age: "",
};

function AddStudent() {
    const [student, setStudent] = useState(initialStudent);
    const [status, setStatus] = useState("");
    const [submitting, setSubmitting] = useState(false);

    function handleChange(event) {
        setStudent({ ...student, [event.target.name]: event.target.value });
    }

    async function handleSubmit(event) {
        event.preventDefault();
        setSubmitting(true);
        setStatus("");

        try {
            const response = await fetch("http://localhost:5264/api/students", {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify({
                    ...student,
                    age: Number(student.age),
                }),
            });

            if (!response.ok) {
                const errorBody = await response.json().catch(() => null);
                const validationErrors = errorBody?.errors;
                const details = validationErrors
                    ? Object.values(validationErrors).flat().join(" ")
                    : errorBody?.detail ?? errorBody?.title;
                throw new Error(details || `Request failed (${response.status})`);
            }

            setStudent(initialStudent);
            setStatus("Student added successfully.");
        } catch (error) {
            console.error("Error adding student:", error);
            setStatus(error instanceof Error ? error.message : "Could not add student.");
        } finally {
            setSubmitting(false);
        }
    }

    return (
        <main className="addstudent">
            <h1>Add Student</h1>
            <form onSubmit={handleSubmit}>
                <label htmlFor="studentName">Name</label>
                <input id="studentName" name="studentName" value={student.studentName} onChange={handleChange} required />

                <label htmlFor="studentClass">Class</label>
                <input id="studentClass" name="studentClass" value={student.studentClass} onChange={handleChange} required />

                <label htmlFor="email">Email</label>
                <input id="email" name="email" type="email" value={student.email} onChange={handleChange} required />

                <label htmlFor="phoneNumber">Phone Number</label>
                <input id="phoneNumber" name="phoneNumber" type="tel" inputMode="tel" value={student.phoneNumber} onChange={handleChange} required />

                <label htmlFor="age">Age</label>
                <input id="age" name="age" type="number" min="1" value={student.age} onChange={handleChange} required />

                <button type="submit" disabled={submitting}>
                    {submitting ? "Adding..." : "Add Student"}
                </button>
                <p role="status" aria-live="polite">{status}</p>
            </form>
        </main>
    );
}

export default AddStudent;