import { React } from "react";
import AssignmentRow from "./AssignmentRow";
const AssignemntCard = ({ assignemnts }) => {
  return (
        <>
          {assignemnts.length > 0}
          ? (
          <ul>
            {assignemnts.map((x) => (
              <AssignmentRow assignemnt={x} />
            ))}
          </ul>
          )
          : <h2>You don't have any assignemnts yet.</h2>
        </>
     
  );
};

export default AssignemntCard;
