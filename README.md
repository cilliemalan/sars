# SARS Tool
This small tool allows you to calculate income tax for South Africa. More importantly, it allows you to back-calculate
the required tax payments from the payout amount or the total-cost-to-company amount (including UIF).

![image](https://user-images.githubusercontent.com/3305301/169113824-11daffad-54c2-42fc-b2f5-fc0712673636.png)

This tool is very useful for:
- When you paid an employee the incorrect amount and you need to back-calculate how to calculate taxes.
- When you have a total-cost-to-company amount and need to solve for PAYE and UIF.
- When you need to generally make payslips.
- When you need to calculate taxes for five years ago.

# Explanation of the fields
- Basic Salary is the gross salary amount *excluding benefits*.
- Bonus is remuneration on top of your regular salary. For tax purposes this is simply added onto the basic salary.
- Earnings is the total remuneration for an employee, including basic salary and benefits. Taxes are calculated from this amount.
- Medical aid is the amount paid for medical aid. *The **amount** does not affect taxes at all* but you get tax credit if you have medical aid.
  It is included on a payslip when an employer pays for an employee's medical aid.
- Number of dependents is the number of dependents including the main member. There is a tax credit for each member.
- Base PAYE (Pay as you Earn) is the amount of taxes before rebates.
- Primary/Secondary/Tertiary rebate. This is an amount subtracted from taxes for people of various 
  ages (primary = under 65, secondary: under 75, tertiary: over 75). There is also a primary/secondary/tertiary threshold income under which no taxes
  are paid. The rebate causes the taxes to start at 0 for people over the threshold instead of suddenly paying a huge amount of taxes if your income
  goes up by 1c.
- PAYE less rebate is the gross income tax amount after applying rebates.
- Medical aid tax credit is the tax credit for people who have medical aid.
- Employee UIF is for Unemployment Insurance Fund and is generally 1% or 148.72, whichever is less.
- Employer UIF is for the same but paid by the employer instead of being a cut of the employee's salary.
- Total deductions is the total amount of deductions for taxes (PAYE and UIF).
- Total payout is the amount paid into the employee's bank account each month and is the basic salary less deductions)
- Total PAYE/UIF/Taxes goes on the SARS EMP201 forms (summed for all employees).

## Notes about taxes
- Though there are various stipends and special categories for taxes, only the gross amount is used for calculating PAYE.
- Medical aid *does not* affect tax calculations. It is only included as employers generally pay it for employees. In South Africa
  there is no special category for medical aid payments and whether or not medical aid is paid by the employee or employer does
  not affect taxes. This means that taxes is calculated from the employee's total remuneration and medical aid is included in that.
  If the employer does not pay for medical aid, it (typically) doesn't appear on the payslip or tax calculations at all. If the employer
  does pay for medical aid, then for tax calculations whatever the amount is is simply added onto the basic salary amount.
- The exception to this rule is the medical aid tax credit, which is irrespective of the amount paid for medical aid. There is a "tax credit"
  for each dependent on the medical aid. This information is sent to SARS directly by your medical aid.
- if the employer has incorrect  information here will be a discrepancy when taxes are filed (for example where an employer has no knowledge
  of medical aid paid by the employee privately. In most cases this means that an employee will get a large payout
  when filing taxes because they technically paid too much taxes throughout the year.
- Total Cost to Company is Employee total remuneration + Employer UIF. This is the total liability for an employee. It can be very difficult
  to calculate taxes from this amount, but this tool can solve for it.
- The tool allows one to calculate taxes back from a payout amount. This is useful for cases where the payout amount has been incorrectly calculate
  and you now need to figure out how much taxes to pay. This is, again, very hard to calculate by hand so this tool can be used solve for this case.
  
 
