import moment from "moment";
import { ErrorMessages, DateTimeFormats } from "utils/constants";

const StockTable = ({ tableMeta, tableData }) => {
  const getTableValue = (key, value) => {
    if (!value) {
      return null;
    }
    if (key === "createdAt") {
      return moment(value).format(DateTimeFormats.default);
    }
    return value.toFixed(2);
  };

  const renderTableBody = () => {
    if (!(tableData && tableData.length)) {
      return (
        <tr>
          <td colSpan={tableMeta?.table?.length}>
            {ErrorMessages.noDataFound}
          </td>
        </tr>
      );
    }
    return tableData.map((item, index) => (
      <tr key={`row-${index}`}>
        {tableMeta.row.map((record, idx) => (
          <td width={"50%"} key={`column-${idx}`}>
            {getTableValue(record.keyName, item[record.keyName])}
          </td>
        ))}
      </tr>
    ));
  };

  return (
    <table>
      <thead>
        <tr>
          {tableMeta?.table?.map((column) => (
            <th key={column.key}>{column.title}</th>
          )) || null}
        </tr>
      </thead>
      <tbody>{renderTableBody()}</tbody>
    </table>
  );
};

export default StockTable;
