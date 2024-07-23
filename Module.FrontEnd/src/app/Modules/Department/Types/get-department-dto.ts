export interface GetDepartmentDto {
    id: number;
    parentDepartmentId: number | null;
    departmentName: string;
    logo: string;
    createdAt: string;
}