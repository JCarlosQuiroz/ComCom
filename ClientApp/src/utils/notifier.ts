

export default function notify(obj: { message: any; toString: () => any; }) {
    openSnackbar({message: obj.message || obj.toString()});
  }

  function openSnackbar(obj: { message: any; variant?: any; }) {
    openSnackbar({message: obj.message, variant: obj.variant || "success"});
}
