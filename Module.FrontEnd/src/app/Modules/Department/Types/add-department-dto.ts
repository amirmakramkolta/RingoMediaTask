export interface AddDepartmentDto {
    departmentName: string;
    logo: string;
    parentDepartmentId: number | null;
}