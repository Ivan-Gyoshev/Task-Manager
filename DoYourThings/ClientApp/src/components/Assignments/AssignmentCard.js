import * as React from "react";
import { Link } from "react-router-dom";
import { useState, useEffect } from "react";
import * as assignmentService from "../../services/assignmentsService";
import AssignmentRow from "../Assignments/AssignmentRow";

export const AssignmentCard = () => {
  const [assignments, setAssignments] = useState([]);
  const userId = JSON.parse(localStorage.getItem('user'))?.id;

  useEffect(() => {
    assignmentService
      .getAll()
      .then((result) => {
        setAssignments(result);
      })
      .catch((err) => {
        console.log(err);
      });
  }, []);


  return (
    <article className="daily">
      <Link to="/assignment-create" className="add-assign">
        Add Assignment
      </Link>
      <article className="assignment-info">
        <h2>Assignments: </h2>
        {assignments.length > 0 ? (
          <>
            {assignments.map((x) => (
              <AssignmentRow assignment={x} />
            ))}
          </>
        ) : (
          <h2>You don't have any assignments yet.</h2>
        )}
      </article>
    </article>
  );
};
