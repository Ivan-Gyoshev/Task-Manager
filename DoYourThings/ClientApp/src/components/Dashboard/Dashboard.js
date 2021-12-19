import React from "react";
import { useState, useEffect } from "react";
import * as assignmentService from "../../services/assignmentsService";
import AssignemntCard from "../Assignments/AssignmentCard";

export const Dashboard = () => {
  const [assignments, setAssignments] = useState([]);

  useEffect(() => {
    assignmentService.getAll
      .then((result) => {
        setAssignments(result);
      })
      .catch((err) => {
        console.log(err);
      });
  }, []);

  return (
    <article className="daily">
      <article className="assignment-info">
        <h2>Assignemnts: </h2>
        <AssignemntCard assignemnts={assignments} />
      </article>
    </article>
  );
};
