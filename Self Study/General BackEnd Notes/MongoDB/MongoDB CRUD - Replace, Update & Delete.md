## Replacing a Document with `replaceOne()`
`replaceOne()` completely replaces the entire document - only `_id` stays the same everything is overwritten.
### Syntax
```JSON
db.nyc.relaceOne(
    { filter },         // which document to find,
    { replacement }    // what to replace it with
)
```
### Example - Replace Court Square Diner entirely:
```JSON
db.nyc.replaceOne( 
    { DBA: "COURT SQUARE DINER" },
    { DBA: "COURT SQUARE DINER UPDATED",
      STREET: "23 STREET",
      INCOME_LEVEL: "high income",
      BOROUGH: "Queens", ZIPCODE: 11101,
      CUISINE_DESCRIPTION: "Greek",
      SCORE: 3,
      GRADE: "A" 
    } 
)
```
### Careful!!
```JSON
// If you do this: 
db.nyc.replaceOne( 
{ DBA: "COURT SQUARE DINER" }, 
{ GRADE: "A" } 
) 
// The document will ONLY have GRADE field left!
 // Everything else is GONE
```
---
## Updating Fields with `updateOne()`
`updateOne()` updates **specific fields only** - the rest of the document stays untouched.

### Operators

| Operator  | What it does          |
| --------- | --------------------- |
| `$set`    | Add or change a field |
| `$inc`    | Increment a number    |
| `$unset`  | Remove a field        |
| `$rename` | Rename a field        |
#### Update just the GRADE and SCORE
```JSON
db.nyc.updateOne(
  { DBA: "COURT SQUARE DINER" },
  { $set: { GRADE: "B", SCORE: 15 } }
)
```
#### Increment the SCORE by 3:
```JSON
db.nyc.updateOne(
  { DBA: "COURT SQUARE DINER" },
  { $inc: { SCORE: 3 } }
)
```
#### Add a brand new field:
```JSON
db.nyc.updateOne(
  { DBA: "COURT SQUARE DINER" },
  { $set: { LAST_INSPECTED: "2024-01-15", IS_OPEN: true } }
)
```
#### `upsert` -- Insert if not found
```JSON
db.nyc.updateOne(
  { DBA: "BRAND NEW CAFE" },
  { $set: { BOROUGH: "Manhattan", GRADE: "A", SCORE: 4 } },
  { upsert: true }   // creates it if it doesn't exist
)
```
---
## `findAndModify()`
`findAndModify()` updates a document AND returns it in one single operation - very useful to see result after the update immediately
### Update score and return the updated document:
```JSON
db.nyc.findAndModify({
  query: { DBA: "COURT SQUARE DINER" },
  update: { $set: { SCORE: 2, GRADE: "A" } },
  new: true    // return the UPDATED version (not the old one),flase return old one
})
```
---
## Updating Many with `updateMany()`
it update **All documents** that match the filter at once
### Set all Queens restaurant to "medium income"
```JSON
db.nyc.updateMany(
  { BOROUGH: "Queens" },
  { $set: { INCOME_LEVEL: "medium income" } }
)
```
### Increment SCORE by 1 for all Grade B restaurants
```JSON
db.nyc.updateMany(
  { GRADE: "B" },
  { $inc: { SCORE: 1 } }
)
```
### Add a new field to ALL documents:
```JSON
db.nyc.updateMany(
  {},   // empty filter = matches EVERYTHING
  { $set: { ACTIVE: true } }
)
```
---
## Deleting Documents

`deleteOne()` - Delete the **first match**:
```JSON
db.nyc.deleteOne({ DBA: "COURT SQUARE DINER" })
```

`deleteMany()` - Delete **All matches**
```JSON
// Delete all Grade C restaurants
db.nyc.deleteMany({ GRADE: "C" })

// Delete all restaurants in a specific zip code
db.nyc.deleteMany({ ZIPCODE: 11101 })

// ⚠️ Delete EVERYTHING in collection
db.nyc.deleteMany({})
```