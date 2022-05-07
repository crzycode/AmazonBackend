use amazon
select * from india_pincode
drop table India_pincode
select * from pincodes where A_Zipcode = 400076
insert into Products select 
Product_Name,
Category,
Selling_Price,
Quantity,
Model_Number,
About_Product,
Product_Specification,
Technical_Details,
Shipping_Weight,
Product_Dimensions,
Image,
Variants,
Product_Url from amazone


insert into pincodes select A_Zipcode, A_Country,A_State, A_City, A_Area, A_District,A_Phone_code,A_iso2,A_Active from india_pincode